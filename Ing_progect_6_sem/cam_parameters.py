import numpy as np
import cv2
import random
import yaml

def __compute_proj_mat(mtx, rvecs, tvecs):  # Вычисление проекционной матрицы
    cam_mtx = np.zeros((3, 4), np.float64)
    cam_mtx[:, :-1] = mtx
    rmat = np.zeros((3, 3), np.float64)
    r_t_mat = np.zeros((3, 4), np.float64)
    cv2.Rodrigues(rvecs[0], rmat)
    r_t_mat = cv2.hconcat([rmat, tvecs[0]], r_t_mat)
    return (cam_mtx * r_t_mat)

def __yaml_save(mtx, dist, rvecs, tvecs, resolution):  # Функция записи в файл
    h, w, = resolution
    pmatrix = __compute_proj_mat(mtx, rvecs, tvecs)
    rm_data = [1, 0, 0, 0, 1, 0, 0, 0, 1]
    mat_data = []
    for i in mtx:
        for x in i: mat_data.append(x)
    mat_data = list(map(float, mat_data))

    dst_data = list(map(float, dist[0]))

    pm_data = []
    for i in pmatrix:
        for x in i: pm_data.append(x)
    pm_data = list(map(float, pm_data))

    data = {"image_width": w,
            "image_height": h,
            "distortion_model": "plumb_bob",
            "camera_name": "raspicam",
            "camera_matrix": {"rows": 3, "cols": 3, "data": mat_data},
            "distortion_coefficients": {"rows": 1, "cols": 8, "data": dst_data},
            "rectification_matrix": {"rows": 3, "cols": 3, "data": rm_data},
            "projection_matrix": {"rows": 3, "cols": 4, "data": pm_data}}
    file = open("camera_parameter{}.yaml".format(random.randint(0,1000)), "w")
    for key in data:
        if type(key) == dict:
            for key2 in key: file.write(yaml.dump({key2: key[key2]}))
        else:
            file.write(yaml.dump({key: data[key]}, default_flow_style=False))

cap = cv2.VideoCapture('C:/Users/ilyah/Desktop/20230521_130537.mp4')

# Defining the dimensions of checkerboard
CHECKERBOARD = (7,10)
criteria = (cv2.TERM_CRITERIA_EPS + cv2.TERM_CRITERIA_MAX_ITER, 15, 0.001)
 
# Creating vector to store vectors of 3D points for each checkerboard image
objpoints = []
# Creating vector to store vectors of 2D points for each checkerboard image
imgpoints = [] 
 
 
# Defining the world coordinates for 3D points
objp = np.zeros((1, CHECKERBOARD[0] * CHECKERBOARD[1], 3), np.float32)
objp[0,:,:2] = np.mgrid[0:CHECKERBOARD[0], 0:CHECKERBOARD[1]].T.reshape(-1, 2)
prev_img_shape = None

max_mod_good_frame = int((int(cap.get(cv2.CAP_PROP_FRAME_COUNT)) % 60))
count_good_frame = 0
count_frame = 1

while cap.isOpened() and (count_good_frame < 60):
    if (count_frame % max_mod_good_frame == 0):
        ret, frame = cap.read()
        # if frame is read correctly ret is True
        if not ret:
            print("Can't receive frame (stream end?). Exiting ...")
            break
        image_resize = cv2.resize(frame, (480, 640), interpolation = cv2.INTER_AREA)
        image_normal = cv2.rotate(image_resize, cv2.ROTATE_90_COUNTERCLOCKWISE)
        gray = cv2.cvtColor(image_normal, cv2.COLOR_BGR2GRAY)
        ret, corners = cv2.findChessboardCorners(gray, CHECKERBOARD, cv2.CALIB_CB_ADAPTIVE_THRESH + cv2.CALIB_CB_FAST_CHECK + cv2.CALIB_CB_NORMALIZE_IMAGE)
        
        if ret == True:
            objpoints.append(objp)
            # refining pixel coordinates for given 2d points.
            corners2 = cv2.cornerSubPix(gray, corners, (11,11),(-1,-1), criteria)
            
            imgpoints.append(corners2)
    
            # Draw and display the corners
            image_normal = cv2.drawChessboardCorners(image_normal, CHECKERBOARD, corners2, ret)
            count_good_frame+=1
            cv2.imshow('img', image_normal)  
    count_frame +=1 
    print("Count good frame now {} in {}".format(count_good_frame, count_frame))
    if cv2.waitKey(1) == ord('q'):
        break
cap.release()
cv2.destroyAllWindows()

h,w = image_normal.shape[:2]
 
print("Wait some time ...")
ret, camera_matrix, dist_coeff, rvecs, tvecs = cv2.calibrateCamera(objpoints, imgpoints, gray.shape[::-1], None, None)
 
print("Camera matrix : \n")
print(camera_matrix)
print("dist : \n")
print(dist_coeff)

__yaml_save(camera_matrix, dist_coeff, rvecs=rvecs, tvecs=tvecs, resolution=gray.shape[::-1])
