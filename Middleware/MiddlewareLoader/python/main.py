import struct
from struct import *

number = 10

pa = struct.pack("Q",number)
print(len(pa))


# Press the green button in the gutter to run the script.
if __name__ == '__main__':
    pass

# See PyCharm help at https://www.jetbrains.com/help/pycharm/