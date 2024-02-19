Here is a simple Java console application that implements a basic version of regular expression matching with `.` and `*`.

```java
import java.util.Scanner;

public class Main {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        System.out.println("Enter the string:");
        String s = scanner.nextLine();
        System.out.println("Enter the pattern:");
        String p = scanner.nextLine();
        System.out.println(isMatch(s, p));
    }

    public static boolean isMatch(String text, String pattern) {
        if (pattern.isEmpty()) {
            return text.isEmpty();
        }
        boolean first_match = (!text.isEmpty() &&
                (pattern.charAt(0) == text.charAt(0) || pattern.charAt(0) == '.'));

        if (pattern.length() >= 2 && pattern.charAt(1) == '*') {
            return (isMatch(text, pattern.substring(2)) ||
                    (first_match && isMatch(text.substring(1), pattern)));
        } else {
            return first_match && isMatch(text.substring(1), pattern.substring(1));
        }
    }
}
```

This application reads a string and a pattern from the console, and then checks if the string matches the pattern. The pattern can include any characters, along with `.` and `*`. The `.` character matches any single character, and the `*` character matches zero or more of the preceding element.