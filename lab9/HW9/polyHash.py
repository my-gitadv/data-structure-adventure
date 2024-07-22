p = 1100101
x = 1001

word = 'abcdABCD01234'

hash = 0
for i in range(len(word)):
    hash = hash + ord(word[i]) * (x**i)

print(hash % p)