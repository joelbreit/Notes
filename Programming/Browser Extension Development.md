# Browser Extension Development Notes

## Basics

### Intro

- Browser extensions are build with web languages: HTML, CSS, and JavaScript
- Browsers provide APIs to interact with the browser and web pages

## Setup

### Required Files

- `manifest.json`: Metadata about the extension (name, version, permissions, etc.)

### Common Files

- `background.js`: Background script that runs in the background and handles events
- `content.js`: Content script that runs in the context of web pages
- `popup.html`: HTML file for the extension's popup
- `options.html`: HTML file for the extension's options page
- `icons/`: Directory for extension icons

### Manifest File

Every browser extension requires a `manifest.json` file. This file is a blueprint for the extension and tells the browser how to load and run the extension.

### Manifest File Structure

```json
{
  "manifest_version": 3,
  "name": "My Extension",
  "version": "1.0",
  "description": "A simple browser extension",
  "permissions": ["storage", "tabs"],
  "background": {
    "service_worker": "background.js"
  },
  "action": {
    "default_popup": "popup.html",
    "default_icon": {
      "16": "icons/icon16.png",
      "48": "icons/icon48.png",
      "128": "icons/icon128.png"
    }
  },
  "content_scripts": [
    {
      "matches": ["<all_urls>"],
      "js": ["content.js"]
    }
  ]
}
```

### Manifest File Fields

#### Required Fields

- `manifest_version`: Version of the manifest file format (2 or 3); **Chrome/Edge require version 3**
- `name`: Name of the extension
- `version`: Version of the extension (e.g., "1.0")

#### Common Fields

- `description`: Description of the extension
- `icons`: Icons for the browser's extension manager
- `version`: Version of the extension (e.g., "1.0")
- `permissions`: *Permissions required by the extension (e.g., "storage", "tabs")*
- `host_permissions`: *Permissions for specific domains (e.g., "https://example.com/*")*
- `background`: *Background script that runs in the background and handles events*
- `content_scripts`: *Content scripts that run in the context of web pages*
  - `matches`: *URL patterns for which the content script should run (e.g., "<all_urls>")*
  - `js`: *JavaScript files to be injected into the matched pages*
- `action`: *Defines the extension's action (popup, icon, etc.)*
- `options_ui`: *Options page for the extension*
- `web_accessible_resources`: *Resources that can be accessed by web pages*
- `commands`: *Keyboard shortcuts for the extension*
- `offline_enabled`: Let the extension keep working with no network.