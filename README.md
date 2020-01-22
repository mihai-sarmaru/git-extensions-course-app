# Visual Git with GitExtensions course starting app

Requirements:
- Visual Studio Code
- Visual Studio Community (optional - needed for homework)

Quick Git Introduction:
- PowerPoint presentation with basic Git explinations

Git Extensions Setup:
- Install Git and GitExtensions
- Settings for user / email / diff / merge (VS Code)
- Clone Repository
- UI overview (branches, timeline, commit, diff, console)

Course App introduction

Workflow: (3 iterations)
- Pull dialog
- Create Branch
- Commit
- Push
- Merge Branch

Basic Features:
- Change Branches (Explorer pane, Checkout menu)
- Pull (Fetch, Merge, Rebase)
- Stash Manager (Stash, Pop, Manager)
- Diff view in editor (VS Code)
- Compare Branches
- File History and Blame

Conflicts: (on 3rd iteration)
- Solve Merge conflicts when Pull

Advanced Features:
- Edit .gitIgnore
- Commit (Selective Stage and Reset, Ammend Commit)
- Force Push
- Revert Commit
- Reset Branch
- Cherry- Pick Commits
- Tags
- Patches
- Prune Branches

Workflows:
- Jira Workflow (with Pull-Requests)
- Github Workflow (with Pull-Requests)



Homework:

Add default.txt (no programming)
- Add a default.txt file which has Default Name for name and 100 for age.

Remove homework text (no programming)
- Remove the homework text using Git only.

Change List title to File Contents (beginner)
- Change the list title from "Extracted names:" to "File Contents:"

Remove homework text (beginner)
- Modify the code and remove the homework text below the buttons.

Add unit tests for Person model (medium)
- Add unit tests for Person model in it's own class

Check for negative age (medium)
- ExtractAge method from TextRepository must verify for negative numbers. Make sure you also update the unit tests for this methods.

Implement sum of all ages (advanced)
- Add a button that calculates the sum of all ages. Make sure it uses MVVM and the corresponding commands and methods are tested.

Write unit tests for the converter and fix possible bug (advanced)
- Create the corresponding class and write unit tests to verify the BoolToVisibilityConverter's methods as they should. Unit test should include private method as well.