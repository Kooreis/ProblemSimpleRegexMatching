if len(pattern) >= 2 and pattern[1] == '*':
        return (is_match(text, pattern[2:]) or
                first_match and is_match(text[1:], pattern))