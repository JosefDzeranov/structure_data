class DynamicArray:
    def __init__(self):
        self.__items = []
        self.__size = 0

    def __init__(self, length):
        self.__items = [0] * length
        self.__size = 0

    def print(self):
        result = ''
        for i in range(self.__size):
            result += self.items[i] + ' '

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


array = DynamicArray(6)
count = array.get_count()  # Получить количество элементов
print(count)  # выводит 0

item = array.get(3) # будет ошибка, так как такого индекса нет

index = array.find(7)  # Получить индекс элемента, равный 7
print(index)  # выводит -1

index = array.find(1)  # Получить индекс элемента, равный 1
print(index)  # выводит -1

printedArray = array.print()  # Распечатать массив
print(printedArray)  # выводит пустую строку
