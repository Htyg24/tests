import matplotlib.pyplot as plt
import sympy
from sympy import *
from random import randint
import math

RANGEE = 10
ACCURACY = 10
func = lambda x : -12*x**4*math.sin(math.cos(x)) - 18*x**3+5*x**2 + 10*x - 30
points = []
for i in range(RANGEE * ACCURACY + 1):
    points.append(((-RANGEE * ACCURACY / 2) + i) / 10)
print(points)
plt.plot(points, 'ro')
#
# x = Symbol('x', domain=S.Reals)
# solve_domain = And(-30 <= x, x <= 30).as_set()
# f = -12*x**4*sin(cos(x)) - 18*x**3+5*x**2 + 10*x - 30
# res = plot(f, (x, -RANGEE, RANGEE))