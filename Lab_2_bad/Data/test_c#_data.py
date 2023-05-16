f = open("HokuyoLidar_lidarlog.txt", 'r')
mas = f.read().split("\n")[0].split("> ")[-1].split()
f.close()
print("len masive is {}".format(len(mas)/360))
step = 240
# for i in range (len(mas)):
#     if mas[i] == '19':     print(i)
# for i in range (100):
#     print("range {} = {}; range {} = {}".format(i, mas[i], i+step, mas[i+step]))
