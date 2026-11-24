# C# Problem-Solving Submission

A personal learning repository for C# programming logic, problem-solving, and data structures and algorithms practice.

The exercises in this repository are completed during programming logic learning sessions. The focus is on understanding each problem, writing pseudocode, implementing the solution independently, and reviewing the result.

## Learning Objectives

- Build a strong foundation in C# syntax and control flow.
- Practice solving programming problems independently.
- Improve array traversal and iteration skills.
- Learn to reason about time and space complexity.
- Develop consistent debugging and review habits.
- Progress gradually toward data structures and algorithms problems.

## Technologies

- C#
- .NET 10
- Visual Studio

## Repository Categories

The repository is organized into the following categories for future exercises:

- `01-Basic-Logic/` - beginner programming logic exercises
- `02-Arrays-and-Strings/` - array and string traversal problems
- `03-Two-Pointers/` - two-pointer problem-solving patterns
- `04-Stacks/` - stack-based problems
- `05-HashMaps/` - lookup and frequency-counting problems
- `06-LeetCode/` - LeetCode practice submissions

The current exercises remain in the existing .NET project files so that the original code, comments, pseudocode, and learning history are preserved.

## Exercise Progress

| # | Exercise | Status | Current implementation | Complexity |
|---|---|---|---|---|
| 1 | Count Even Numbers | Completed | `Solutions.CountEvenNumbers` | O(n) time, O(1) space |
| 2 | Count Numbers Greater Than 10 | Completed | `Solutions.CountNumberGreaterThanTen` | O(n) time, O(1) space |
| 3 | Sum of Even Numbers | Completed | `Solutions.SumOfEvenNumbers` | O(n) time, O(1) space |
| 4 | Find the Largest Number | Completed | `Solutions.FindTheLargestNumber` | O(n) time, O(1) space |
| 5 | Find the Smallest Number | Completed | `Solutions.FindTheSmallNumber` | O(n) time, O(1) space |
| 6 | Count Positive and Negative Numbers | Completed | `Solutions.CountPositiveAndNegativeNum` | O(n) time, O(1) space |
| 7 | Count Occurrences of a Number | Completed | `Solutions.CountOccurrencesOfNum` | O(n) time, O(1) space |
| 8 | Find the First Occurrence | Completed in the current workspace | `Solutions.FindTheFirstOccurrence` | O(n) time, O(1) space |

Pseudocode and learning notes are preserved in `01-Basic-Logic/BasicLogicPseudocode.txt`. The current `Program.cs` demonstrates the existing exercises.

## Exercise Documentation Format

Future exercise documentation should use this structure:

1. Problem title
2. Problem description
3. Sample input and output
4. Completed pseudocode
5. C# implementation
6. Time complexity
7. Space complexity
8. Completion status

Only exercises that have actually been worked on should be documented as completed. Pending exercises should not receive an implementation until they are solved independently.

## How to Run

From the repository root, run:

```powershell
dotnet run --project .\LeetCodeSolutions.csproj
```

To build without running:

```powershell
dotnet build .\LeetCodeSolutions.csproj
```

The project targets .NET 10 and uses `Program.cs` as its executable entry point.

## Problem-Solving Workflow

Each exercise follows this learning workflow:

1. Understand the question, scenario, and inputs.
2. Write pseudocode.
3. Visualize each iteration.
4. Implement the solution independently in C#.
5. Review and debug.
6. Analyze time and space complexity.

## Future Learning Goals

- Strengthen fundamentals with more array and string problems.
- Practice two-pointer and sliding-window techniques.
- Learn stacks, queues, and hash maps through small exercises.
- Add focused tests for completed solutions.
- Progress to recursion, sorting, searching, linked lists, trees, and graphs.
- Continue building LeetCode problem-solving confidence.

## Repository Guidelines

- Preserve original solutions, comments, pseudocode, and learning notes.
- Prefer simple, readable implementations while learning.
- Do not replace learning exercises with unnecessarily advanced solutions.
- Do not implement an exercise before its problem and pseudocode have been understood.
- Keep the project compatible with its existing .NET version.
