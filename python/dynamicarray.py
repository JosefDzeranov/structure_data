class DynamicArray:
    def __init__(self, length=0):
        self.__items = [0] * length
        self.__size = 0

    def print(self):
        result = ''
        for i in range(self.__size):
            result += str(self.__items[i]) + ' '

        return result

    def get_count(self):
        return self.__size

    def get(self, index):
        if index >= self.__size or index < 0:
            raise Exception("Индекс находится за пределами массива.")
        return self.__items[index]

    def find(self, key):
        for i in range(self.__size):
            if self.__items[i] == key:
                return i
        return -1

    def increase_array(self):
        new_count = self.__size * 2
        if self.__size == 0:
            new_count = 4

        new_array = [0] * new_count
        for i in range(self.__size):
            new_array[i] = self.__items[i]

        self.__items = new_array

    def push_back(self, item):
        if self.__size == len(self.__items):
            self.increase_array()

        self.__items[self.__size] = item
        self.__size += 1

    def insert(self, index, item):
        if index < 0 or index > self.__size:
            raise Exception("Выход за пределами массива")

        if self.__size == len(self.__items):
            self.increase_array()

        # сдвигаем все элементы вправо до нужного индекса
        for i in range(self.__size - 1, index - 1, -1):
            self.__items[i + 1] = self.__items[i]

        self.__items[index] = item
        self.__size += 1

    def push_front(self, item):
        self.insert(0, item)

    def pop_back(self):
        if self.__size == 0:
            raise Exception("Массив пустой.")
        self.__size -= 1

    def remove_by_index(self, index):
        if self.__size == 0:
            raise Exception("Массив пустой!")

        if index < 0 or index >= self.__size:
            raise Exception("Выход за пределами массива")

        for i in range(index + 1, self.__size):
            self.__items[i - 1] = self.__items[i]

        self.__size -= 1

    def pop_front(self):
        self.remove_by_index(0)

    # задачи

    def find_last(self, key):
        for i in range(self.__size - 1, -1, -1):
            if self.__items[i] == key:
                return i

        return -1

    def push_back_range(self, array):
        for item in array:
            self.push_back(item)

    def insert_range(self, index, array):
        for i in array:
            self.insert(index, i)
            index += 1

    def remove(self, item):
        index = self.find(item)
        if index == -1:
            return False

        self.remove_by_index(index)
        return True

    def remove_all(self, item):
        count = 0
        index = self.find(item)
        while index >= 0:
            self.remove_by_index(index)
            count += 1
            index = self.find(item)
        return count


line = input().split()
before_remove_length = len(line)
dynamic_array = DynamicArray()
for item in line:
    dynamic_array.push_back(int(item))

item_to_remove = int(input())

removed_elements_counts = dynamic_array.remove_all(item_to_remove)
print(dynamic_array.print())

after_remove_length = dynamic_array.get_count()

if before_remove_length != after_remove_length + removed_elements_counts:
    raise Exception("Метод \"RemoveAll\" возвращает неправильное значение")

# remove
line = input().split()
before_remove_length = len(line)
dynamic_array = DynamicArray()

for item in line:
    dynamic_array.push_back(int(item))

item_to_remove = int(input())

is_remove = dynamic_array.remove(item_to_remove)
print(dynamic_array.print())

after_remove_length = dynamic_array.get_count()

if before_remove_length == after_remove_length and is_remove:
    raise Exception("Метод \"Remove\" возвращает неправильное значение")

if before_remove_length != after_remove_length and not is_remove:
    raise Exception("Метод \"Remove\" возвращает неправильное значение")

# insert_range
# line = input().split()
# line2 = input().split()
# array = []
# for item in line2:
#     array.append(int(item))
#
# index = int(input())
# expected_length = len(line) + len(line2)
#
# dynamic_array = DynamicArray()
# for item in line:
#     dynamic_array.push_back(int(item))
#
# dynamic_array.insert_range(index, array)
#
# if dynamic_array.get_count() != expected_length:
#     raise Exception("Кол-во элементов в массиве должна быть равна сумме длин двух массивов.")
#
# print(dynamic_array.print())

# line = input().split()
# line2 = input().split()
# array = []
# for item in line2:
#     array.append(int(item))
#
# expected_length = len(line) + len(line2)
# dynamic_array = DynamicArray()
# for item in line:
#     dynamic_array.push_back(int(item))
#
# dynamic_array.push_back_range(array)
#
# if dynamic_array.get_count() != expected_length:
#     raise Exception("Кол-во элементво в массиве должна быть равна сумме длин двух массивов.")
#
# print(dynamic_array.print())
# push_back_range


# find_last
# line = input().split()
# beforeLength = len(line)
# dynamic_array = DynamicArray()
# for item in line:
#     dynamic_array.push_back(int(item))
#
# beforePrinted = dynamic_array.print()
#
# itemToFind = int(input())
# index = dynamic_array.find_last(itemToFind)
# print(index)
#
# afterRemoveLength = dynamic_array.get_count()
# if beforeLength != afterRemoveLength:
#     raise Exception("Метод \"FindLast\" изменяет кол-во элементов")
#
# afterPrinted = dynamic_array.print()
# if beforePrinted != afterPrinted:
#     raise Exception("Метод \"FindLast\" изменяет элементы массива")
# array = DynamicArray(6)
# array.push_back(3)  # добавить в конец 10
# array.push_back(1)  # добавить в конец 10
# array.push_back(7)  # добавить в конец 10
# array.push_back(10)  # добавить в конец 10
# array.push_back(5)  # добавить в конец 5
# array.push_back(6)  # добавить в конец 5
# print(array.print())
#
# array.pop_back()  # Удалить последний элемент
# print(array.print())  # выводит "3 1 7 10 5"
# print(array.get_count())  # выводит 5
#
# array.pop_front()  # Удалить первый элемент
# print(array.print())  # выводит "1 7 10 5"
# print(array.get_count())  # выводит 4
#
# array.remove_by_index(1)  # Удалить элемент под индексом 1
# print(array.print())  # выводит "1 10 5"
# print(array.get_count())  # выводит 3
#
# array.pop_back()  # Удалить последний элемент. Массив состоит из 2 элемента
# array.pop_back()  # Удалить последний элемент. Массив состоит из 1 элемента
# array.pop_back()  # Удалить последний элемент. Массив пустой.
# print(array.get_count())  # выводит 0
# array.pop_back()  # Удалить последний элемент. Будет ошибка

# 2 урок
# array = DynamicArray(6)
# array.push_back(10)  # добавить в конец 10
# array.push_back(5)  # добавить в конец 5
# print(array.print())  # выводит "10 5"
#
# array.push_front(1)  # добавить в начало 1
# array.push_front(3)  # добавить в начало 3
# print(array.print())  # выводит "3 1 10 5"
#
# array.insert(2, 7)  # добавить 7 в элемент под индексом 2
# print(array.print())  # выводит "3 1 7 10 5"
#
# item = array.get(3)  # взять элемент под индексом 3
# print(item)  # выводит 10
#
# index = array.find(7)  # Получить индекс элемента, равный 7
# print(index)  # выводит 2
#
# index = array.find(8)  # Получить индекс элемента, равный 8
# print(index)  # выводит -1
#
# count = array.get_count()  # Получить количество элементов
# print(count)  # выводит 5
#
# # Заполняем массив
# array.push_back(6)
# array.push_back(7)  # НЕ будет ошибки. Массив динамический
# print(array.print())  # выводит "3 1 7 10 5 6 7"

# первый урок
# array = DynamicArray(6)
# count = array.get_count()  # Получить количество элементов
# print(count)  # выводит 0
#
# item = array.get(3) # будет ошибка, так как такого индекса нет
#
# index = array.find(7)  # Получить индекс элемента, равный 7
# print(index)  # выводит -1
#
# index = array.find(1)  # Получить индекс элемента, равный 1
# print(index)  # выводит -1
#
# printedArray = array.print()  # Распечатать массив
# print(printedArray)  # выводит пустую строку
