# -GPACalculator-
mermaid
classDiagram
    class GPACalculator {
        - double gpaSum
        - int studentCount
        - double gpaMax
        - double gpaMin
        + boolean setGPA(double gpa)
        + double getGPAx()
        + double getMaxGPA()
        + double getMinGPA()
        + int getStudentCount()
        + void displayInfo()
    }
