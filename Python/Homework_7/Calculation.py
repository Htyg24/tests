import Convert
from Log import Add_log

def Guid(file_name = 'text.txt'):
    expression = Convert.Convert(file_name)
    while '(' in expression:
        expression = Brackets(expression, 0, len(expression))
    expression = Mult_div(expression, 0, len(expression))
    Add_log((expression))
    return Sum_sub(expression, 0, len(expression))


def Mult_div(expression, start, end):
    i = start
    while i < end:
        if expression[i] == '*':
            expression[i - 1] *= expression[i + 1]
            expression = Waste(expression, i, i)
            end -= 2
            i -= 1
        elif expression[i] == '/':
            expression[i - 1] /= expression[i + 1]
            expression = Waste(expression, i, i)
            end -= 2
            i -= 1
        i += 1
    return expression


def Sum_sub(expression, start, end):
    i = start
    while i < end:
        if expression[i] == '+':
            expression[i - 1] += expression[i + 1]
            expression = Waste(expression, i, i)
            end -= 2
        elif expression[i] == '-':
            expression[i - 1] -= expression[i + 1]
            expression = Waste(expression, i, i)
            end -= 2
        i += 1
    return expression


def Brackets(expression, start, end):
    i = start
    count = 0
    while i < end:
        if expression[i] == '(':
            start = i
        if expression[i] == ')':
            end = i
            expression = Sum_sub(Mult_div(Waste(expression, end, start), start, end - 2), start, end - 2)
            return expression
        i += 1


def Waste (expression, end, start):
    expression.pop(end)
    expression.pop(start)
    return expression