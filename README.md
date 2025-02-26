# Computer Science Challenge

## Introduction
This repo is part of the Computer Science Challenge, where I solve and explain LeetCode problems. Each problem includes a breakdown of the solution along with an analysis of its time and space complexity.

## Problems

### 78. Subsets
This solution generates all possible subsets of a given integer array `nums` using an **iterative approach**. It starts with an initial subset (the empty set) and progressively builds new subsets by adding each number in `nums` to the existing subsets.

**Time complexity:** O(2^n * n)

**Space complexity:** O(2^n * n)

### 13. Roman to integer
This solution converts a **Roman numeral** string into an **integer** using a dictionary for lookup and a single pass through the string. It iterates over `s`, adding values from the dictionary unless a **smaller** numeral precedes a **larger** one (e.g., "IV" or "XC"), in which case it subtracts **twice** the previous value (since it was already added).

**Time complexity:** O(n)

**Space complexity:** O(1)

### 151. Reverse words in a String
This solution reverses the words in a given string `s` while removing extra spaces. It first **splits** the string into words using `Split(' ', StringSplitOptions.RemoveEmptyEntries)`, which removes extra spaces. Then, it **reverses** the order of the words using `.Reverse()` and finally **joins** them back into a single string with spaces using `string.Join(" ", ...)`.

**Time complexity:** O(n)

**Space complexity:** O(n)

### 206. Reverse linked list
This solution reverses a **singly linked list** using an **iterative approach**. It maintains three pointers: `prev` (initially `null`), `current` (starting at `head`), and `next` (to track the next node). In each iteration, it reverses the `next` pointer of `current` to point to `prev`. Then, it moves `prev` forward to `current` and `current` to `next`, until reaching the end of the list. Finally, `prev` (which is now the last node) becomes the new head.

**Time complexity:** O(n)

**Space complexity:** O(1)

# 92. Reverse linked list II
This solution **reverses a sublist** within a singly linked list from position `left` to `right`, while keeping the rest of the list unchanged. It extends the **iterative reversal approach** used in the *Reverse a Linked List* problem but only applies it to a specific section.

To ensure reconnection after reversing, we introduce two key pointers:

- **`prevLeft`**: This pointer is used to find the node **before** the sublist that needs to be reversed. Once the reversal is complete, `prevLeft.next` is updated to point to `prev`, which is now the new head of the reversed sublist.
- **`tail`**: This pointer keeps track of the original `left` position, which after reversal becomes the last node in the reversed sublist. Once the reversal is finished, `tail.next` is updated to `current` (the first node after `right`), ensuring the list remains properly connected.

**Time complexity:** O(n)

**Space complexity:** O(1)

### 214. Shortest palindrome
This solution finds the **shortest palindrome** by identifying the **longest palindromic prefix** in `s` using a **rolling hash** technique. It maintains two hash values: `prefix` (computed from left to right) and `suffix` (computed from right to left). If at any position these hashes match, it means the prefix up to that point is a palindrome, so we track the longest palindromic prefix index. After identifying this prefix, the remaining part of the string (suffix) is extracted, reversed, and **added to the beginning** of `s`, ensuring the resulting string is the shortest possible palindrome. The **mod (`1e9 + 7`)** is used to prevent integer overflow and reduce hash collisions, while the **base (`31`)** ensures a unique rolling hash.

**Time complexity:** O(n)

**Space complexity:** O(n)

### 48. Rotate image
The algorithm rotates an `N x N` matrix **90 degrees clockwise in place** by processing it layer by layer. The outer loop iterates through each layer from the outermost to the innermost, stopping at `N/2` layers. For each layer, it identifies the `first` and `last` indices, then rotates elements in **groups of four**, performing a circular swap between the **top, right, bottom, and left** positions. The swapping is controlled by an `offset` variable, ensuring that the correct elements are moved to their respective positions without using extra space. The process continues until all layers are rotated, modifying the matrix directly.

**Time complexity:** O(n^2)

**Space complexity:** O(1)

### 32. Longest valid parentheses
The algorithm finds the longest valid parentheses substring using **dynamic programming (DP)**. It initializes an array `dp[]` of length `n`, where each entry stores the length of the longest valid parentheses substring ending at that index. The loop starts from index `1` since a single character cannot form a valid sequence. If the current character is a closing parenthesis `)`, two cases are considered. If the previous character is an opening parenthesis `(`, the `dp` value at the current index is updated by adding `2` to the `dp` value at `i-2`, if it exists. Otherwise, if the previous character is also `)`, but there exists a matching `(` before the valid substring, the algorithm calculates the valid length by adding `dp[i-1] + 2` and checking if there is an earlier valid sequence to append. The maximum valid length found is stored in `maxLen`, which is returned at the end.

**Time complexity:** O(n)

**Space complexity:** O(n)


