# Git CLI

## Terminology

### Places in Git

1. **local directory**: the saved files currently on your computer
2. **staging area**: set of files that have been added but not committed; same as the index
3. **index**: set of files that have been added but not committed; same as the staging area
4. **local repository**: set of files that have been committed even if they are not yet pushed remotely
5. **remote repository**: the files that exist on the remote git server
6. **HEAD**: the commit that is currently checked out (usually the most recent commit on the current branch)
7. **detached HEAD**: when your current repo is pointed to a commit that is not the most recent commit on a branch

```mermaid
graph TD
  A[local directory] --> B[staging area]
  B --> C[local repository]
  C --> D[remote repository]
  C --> E[HEAD]
```

### Other

1. **WIP** - "Work In Progress"; signals that a commit is not final and might be updated later
2. **Untracked** - "Untracked" just refers to files that are not in prior commits or the staging area. Everything else is "tracked" by Git.

## Configuration

**Set user name and email**

```bash
git config --global user.name "Joel Breit"
git config --global user.email "Joel@Breitest.com"
```

**List config settings** - `git config list`

**Get specific config settings (by name)**

- `git config get [name]`
- Ex: `git config get user.name`

## Commands

**help**

**init** - Initialize a new Git repo

- `git init

Uninitialize a Git repo

- `rm -rf .git`

**branch** - Edit or view branches

- `git branch [flags] [branch_name]`
- `git branch` - Display the current branch
- Flags:
  - `-a`: List all branches `git branch -a`
  - `-d`: Delete a branch `git branch -d old_branch`
  - `-m`: Rename a branch
    - Current branch: `git branch -m new_branch`
    - Different branch: `git branch -m old_branch new_branch`
  - `-r`: List remote branches `git branch -r`
  - `-u`: Set upstream branch `git branch -u origin/master`

**stash** - Temporarily save changes in the working directory
- The stash is a stack of change sets that can be applied later
- `git stash [command] [flags]`
  - Commands:
    - ~~`git stash`: Same as push, but deprecated~~
    - ~~`git stash save [message]`: Same as push with -m, but deprecated~~
    - `git stash push`: Save changes to the stash
      - `-m` or `--message`: Add a message to the stash
        - E.g. `git stash push -m "WIP: Fix bug in feature X"`
      - `-u` or `--include-untracked`: Include untracked (new) files
    - `git stash pop`: Apply the most recent stash and remove it
    - `git stash apply`: Apply the most recent stash without removing it
    - `git stash list`: List all stashes
    - `git stash drop [stash@{n}]`: Remove a specific stash
    - `git stash clear`: Remove all stashes

**clean** - Remove untracked files

- `git clean [flags]`
- Flags:
  - `-d`: Remove untracked directories
  - `-f`: Force the clean
  - `-i`: Interactive mode
  - `-n`: Dry run (show what would be removed)
  - `-x`: Remove ignored files as well

**log** - View commit history

- `git log [flags]`
- `git log --oneline --graph` - Show a graph of the commit history
- Flags:
  - `--oneline`: Show each commit on one line
  - `--graph`: Show a graph of the commit history

**tag** - Create, list, or delete tags

- `git tag [flags] [tag_name] [commit]`
- `git tag` - List tags
- `git tag -a [tag_name] -m [message]` - Create an annotated tag
- `git tag -d [tag_name]` - Delete a tag
- `git push origin --delete [tag_name]` - Delete a tag from remote
- `git tag -f [tag_name] [commit]` - Move a tag to a different commit
- `git push --tags` - Push all tags to remote
  - Git does not push tags by default
- `git checkout [tag_name]` - Checkout a tag
- Flags:
  - `-a`: Create an annotated tag
  - `-m`: Message for (an annotated) tag
  - `-d`: Delete a tag
  - `-v`: Verify a tag
  - `-f`: Move a tag to a different commit

**diff** - Show changes between commits, branches, etc.

- `git diff [flags] [commit1] [commit2]`
- `git diff` - diff between working directory and staging area
- `git diff --cached` - diff between stage and last commit
- `git diff HEAD` - diff between working directory and current HEAD
- `git diff [commit1] [commit2]` - diff between two commits
- Flags:
  - `--cached`: diff between stage and last commit
  - `--name-only`: Show only the names of changed files
  - `--name-status`: Show only the names and status of changed files
  - `--stat`: Show statistics about changes

**move** - Move or rename a file so that Git tracks the move

- `git mv [old_file] [new_file]`
- Git will usually detect moves automatically, but you won't see that until you at least stage the changes. It may also get confused if you move/rename a file and then edit it in the same commit, so this command is helpful then.

**clone** - Clone a remote repository

- `git clone [repo_url] [directory]`
- `git clone [repo_url]` - Clone into a directory with the same name as the repo
- Clone from one local repo to another
  - `git clone /path/to/repo /path/to/destination`

**remote** - Manage remote repositories

- `git remote [flags] [remote_name] [remote_url]`
- `git remote -v` - List remote repositories
- `git remote add [remote_name] [remote_url]` - Add a remote repository
- `git remote remove [remote_name]` - Remove a remote repository

**fetch** - Download objects and refs from remote repository
- Updates your local copy of a repo to match the remote. By default, it fetches all branches from the remote, and that can also be configured.
- `git fetch [remote]`
- `git fetch --all` - Fetch all remotes
- `git fetch [remote] [branch]` - Fetch a specific branch from a remote
- `git fetch --prune` - Remove any remote-tracking branches that no longer exist on the remote
- `git fetch --tags` - Fetch all tags from the remote
- `git fetch --prune-tags` - Remove any remote-tracking tags that no longer exist on the remote

**bisect** - Find the commit that introduced a bug

- `git bisect start` - Start bisecting
- `git bisect bad` - Mark the current commit as bad
- `git bisect good [commit]` - Mark a specific commit as good
- `git bisect reset` - Reset bisecting
- `git bisect run <script>` - Run a script to test if the commit is good or bad
  - The **script** (e.g. ./test.sh) should exit with 0 if the commit is good, and 1 if the commit is bad.

## Esoteric Commands I Like

Display the name, commit hash, and date of every tag in the repo:

`git for-each-ref --format '%(refname:short) %(objectname) %(creatordate)' refs/tags`

Display the name, commit hash, and date of every tag in the repo, sorted by date:

`git log --graph --oneline --all`

Show all authors of the repo sorted by number of commits:

`git log --format='%an <%ae>' | sort | uniq -c | sort -nr`

Display lines of code added/removed **since a specific date**, grouped by author, for specific file types:

```bash
git log --since="2025-01-01" --pretty=format:"author:%an" --numstat -- '*.cpp' '*.h' '*.cs' '*.md' | awk '
/^author:/ {current_author=substr($0,8)}
/^[0-9]/ {
  added[current_author]+=$1
  removed[current_author]+=$2
}
END {
  printf "%-20s %10s %10s\n", "Author", "Added", "Removed"
  for (a in added)
    printf "%-20s %10d %10d\n", a, added[a], removed[a]
}'
```

Ditto but with a date range:

```bash
git log \
  --since="2025-01-01" \
  --until="2025-02-01" \
  --pretty=format:"author:%an" \
  --numstat \
  -- '*.cpp' '*.h' '*.cs' '*.md' \
| awk '
/^author:/ {
  current_author=substr($0,8)
}
/^[0-9]/ {
  added[current_author]+=$1
  removed[current_author]+=$2
}
END {
  printf "%-20s %10s %10s\n", "Author", "Added", "Removed"
  for (a in added)
    printf "%-20s %10d %10d\n", a, added[a], removed[a]
}'
```

## TODO

- [ ] reset
- [ ] rev-parse
- [ ] "Rebase onto" vs "Merge into" vs "Fast-forward to"
- [ ] `git rm {item} --cached`
- [ ] Change sets - computed, not handled by Git (Git has blobs and deltas)
- [ ] Object types in Git
  - [ ] Blob
  - [ ] Tree
  - [ ] Commit
  - [ ] Tag
  - [ ] DAG
  - [ ] SHA
  - [ ] Deltas
- [ ] Hunks
- [ ] "Squash commits"
- [ ] "Packed"
- [ ] Cherry-picking
- [ ] Garbage collection in git
- [ ] Rename a folder
- [ ] Git hooks