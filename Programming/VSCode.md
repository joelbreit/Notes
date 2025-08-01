# VSCode Notes

### List all **non-default (user-defined)** settings in Visual Studio Code:

1. Open the **Command Palette** (`Ctrl+Shift+P` or `Cmd+Shift+P` on macOS).
2. Type and select:  
   **Preferences: Open User Settings (JSON)**

   This opens your `settings.json` file, which shows only the settings you've **explicitly changed** — these are the **non-default** ones.

---

### Export/Compare Settings and Extensions
For a full export of your environment (settings + extensions):
```bash
code --list-extensions > extensions.txt
code --export-default-configuration > config.json
```

### Add Developer Command Prompt Profiles

Add to settings.json:

```json
"terminal.integrated.profiles.windows": {
    // ...
    "DCP amd64": {
        "path": [
            "cmd.exe"
        ],
        "args": [ "/k", "C:\\Program Files (x86)\\Microsoft Visual Studio 14.0\\VC\\vcvarsall.bat", "amd64"]
    },
    "DCP x86": {
        "path": [
            "cmd.exe"
        ],
        "args": [ "/k", "C:\\Program Files (x86)\\Microsoft Visual Studio 14.0\\VC\\vcvarsall.bat", "x86"]
    }
}
```

## VSCode Extensions


### Extension Details

<!-- Identifier
eamodio.gitlens
Version
16.2.1

Identifier
yzhang.markdown-all-in-one
Version
3.6.2

Identifier
mechatroner.rainbow-csv
Version
3.14.0 -->

```yaml
GitLens:
    publisher: "eamodio"
    extensionName: "gitlens"
    version: "16.2.1"
Markdown All in One:
    version: "3.6.2"
    publisher: "yzhang"
    extensionName: "markdown-all-in-one"
Rainbow CSV:

    publisher: "mechatroner"
    extensionName: "rainbow-csv"
    version: "3.14.0"
```

~~### Commands~~

> **TODO** - This just doesn't work for some reason. It consistently produces `The file is not a valid VSIX package.`


~~Template~~:
`https://marketplace.visualstudio.com/_apis/public/gallery/publishers/{publisher}/vsextensions/{extensionName}/{version}/vspackage`

```bash
# GitLens
curl -L -o gitlens.vsix https://marketplace.visualstudio.com/_apis/public/gallery/publishers/eamodio/vsextensions/gitlens/16.2.1/vspackage
# Markdown All in One
curl -L -o markdown-all-in-one.vsix https://marketplace.visualstudio.com/_apis/public/gallery/publishers/yzhang/vsextensions/markdown-all-in-one/3.6.2/vspackage
# Rainbow CSV
curl -L -o rainbow-csv.vsix https://marketplace.visualstudio.com/_apis/public/gallery/publishers/mechatroner/vsextensions/rainbow-csv/3.14.0/vspackage
```

```bash
# publisher.extension and version you want
PUB="ms-python"
EXT="python"
VER="2024.4.0"          # use 'latest' to always fetch newest

curl -L \
"https://marketplace.visualstudio.com/_apis/public/gallery/publishers/${PUB}/vsextensions/${EXT}/${VER}/vspackage" \
-o "${PUB}.${EXT}-${VER}.vsix"
```
