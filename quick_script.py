from random import choice, randint


def generate_students():
    names = ['Kacper', 'Szymon', 'Paulina', 'Łukasz', 'Jolanta', 'Wojciech', 'Adrian', 'Marcelina']
    surnames = ['Nowak', 'Kowal', 'Adamiak', 'SQLowski', 'Kowalski', 'Wiśniewski', 'Wójcik']
    s_index = 33000
    students = []

    for student_entity in range(40):
        students.append((s_index, names[randint(0, len(names)-1)], surnames[randint(0, len(surnames)-1)]))
        s_index += 1
    return students

def generate_grades():
    s_index = 33000
    grades = []

    for student in range(40):
        for assignments in range(randint(0, 4)):
            tmp = [f'0{day}' for day in range(1, 10)]
            days = tmp + [str(day) for day in range(10, 32)]
            month = tmp + ['10', '11', '12']
            date = f'{choice(days)}.{choice(month)}.2022'
            grades.append((str(s_index), str(randint(1, 7)), f"CONVERT('{date}', 104)"))
        s_index += 1
    return grades

# sdts = generate_students()
# for student_entity in sdts:
#     print(str(student_entity) + ',')

grds = generate_grades()
for grade in grds:
    print(str(grade) + ',')
