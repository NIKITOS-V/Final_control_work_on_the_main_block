import os


class ShortStrings:
    LenStr = 3

    def __init__(self):
        self.UserArray = input("Введите строку: ") .split()
        self.ArrayOfShortStrings = []

        self.FindShortStrings()
        self.PrintResult()

    def FindShortStrings(self):
        Strings = ""

        for str in self.UserArray:
            if len(str) <= self.LenStr:
                Strings += f"{str} "
        self.ArrayOfShortStrings = Strings.split()

    def PrintResult(self):
        print(self.ArrayOfShortStrings)


SS = ShortStrings()

os.system("pause")
