class GPACalculator:
    def __init__(self):
        self.gpa_sum = 0.0
        self.n = 0
        self.gpa_min = float('inf')
        self.gpa_max = float('-inf')

    def setGPA(self, gpa: float) -> bool:
        if gpa < 0.0 or gpa > 4.0:
            return False
        self.gpa_sum += gpa
        self.n += 1
        self.gpa_min = min(self.gpa_min, gpa)
        self.gpa_max = max(self.gpa_max, gpa)
        return True

    def getGPAx(self) -> float:
        return round(self.gpa_sum / self.n, 2) if self.n > 0 else 0.0

    def getMaxGPA(self) -> float:
        return round(self.gpa_max, 2) if self.n > 0 else 0.0

    def getMinGPA(self) -> float:
        return round(self.gpa_min, 2) if self.n > 0 else 0.0

    def showStatistics(self):
        print(f"จำนวนคน: {self.n}")
        print(f"GPAx: {self.getGPAx():.2f}")
        print(f"คะแนนสูงสุด: {self.getMaxGPA():.2f}")
        print(f"คะแนนต่ำสุด: {self.getMinGPA():.2f}")

# ตัวอย่างการใช้งาน
calculator = GPACalculator()
grades = [3.5, 2.8, 4.0, 3.2, 3.9]
for g in grades:
    calculator.setGPA(g)

calculator.showStatistics()

