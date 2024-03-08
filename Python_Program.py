class ShortStrings:
    LenStr = 3

    def __init__(self):
        self.UserArray = input("Введите строку: ") .split()
        self.ArrayOfShortStrings = []

        self.FindShortStrings()
        self.PrintResult()

    def FindShortStrings(self):
        for str in self.UserArray:
            if len(str) <= self.LenStr:
                self.ArrayOfShortStrings.append(str)

    def PrintResult(self):
        print(self.ArrayOfShortStrings)


SS = ShortStrings()
