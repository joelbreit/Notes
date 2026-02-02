# Web App Development

```
my-app/
├── README.md
├── docs/
│   ├── architecture.md
│   ├── deployment.md
│   ├── development-setup.md
│   └── api-reference.md
│
├── backend/
│   ├── README.md
│   ├── template.yaml # SAM template
│   ├── samconfig.toml
│   ├── .gitignore
│   │
│   ├── src/
│   │   ├── functions/
│   │   │   ├── get-items/
│   │   │   │   ├── index.js (or .ts)
│   │   │   │   ├── handler.test.js
│   │   │   │   └── README.md
│   │   │   ├── create-item/
│   │   │   └── update-item/
│   │   │
│   │   ├── layers/ # Shared code
│   │   │   └── common/
│   │   │       ├── utils.js
│   │   │       └── db-client.js
│   │   │
│   │   └── shared/ # Additional shared resources
│   │       ├── models/
│   │       └── middleware/
│   │
│   └── tests/
│       ├── integration/
│       └── unit/
│
├── frontend/
│   ├── README.md
│   ├── package.json
│   ├── vite.config.js
│   ├── index.html
│   ├── .gitignore
│   │
│   ├── public/
│   │   └── assets/
│   │
│   ├── src/
│   │   ├── main.jsx
│   │   ├── App.jsx
│   │   │
│   │   ├── components/
│   │   │   ├── common/
│   │   │   └── features/
│   │   │
│   │   ├── pages/
│   │   ├── hooks/
│   │   ├── services/
│   │   │   └── api.js # API client for backend
│   │   ├── utils/
│   │   ├── styles/
│   │   └── config/
│   │       └── env.js
│   │
│   └── docs/
│       └── components.md
│
├── scripts/
│   ├── deploy.sh
│   ├── local-dev.sh
│   └── README.md
│
└── .cursorrules # Cursor/Claude Code instructions
```