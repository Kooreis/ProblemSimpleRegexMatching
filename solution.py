Here is a Python console application that implements a simple version of regular expression matching with `.` and `*`.

```python
def is_match(text, pattern):
    if not pattern:
        return not text

    first_match = bool(text) and pattern[0] in {text[0], '.'}

    if len(pattern) >= 2 and pattern[1] == '*':
        return (is_match(text, pattern[2:]) or
                first_match and is_match(text[1:], pattern))
    else:
        return first_match and is_match(text[1:], pattern[1:])


def main():
    text = input("Enter the text: ")
    pattern = input("Enter the pattern: ")
    print(is_match(text, pattern))


if __name__ == "__main__":
    main()
```

This console application first asks the user to input a text and a pattern. It then checks if the pattern matches the text using the `is_match` function and prints the result. The `is_match` function uses recursion to check if the pattern matches the text. It first checks if the first character of the text matches the first character of the pattern or if the first character of the pattern is a `.`. If the second character of the pattern is a `*`, it checks if the rest of the pattern matches the text or if the first character of the text matches the first character of the pattern and the rest of the text matches the pattern. If the second character of the pattern is not a `*`, it checks if the first character of the text matches the first character of the pattern and the rest of the text matches the rest of the pattern.