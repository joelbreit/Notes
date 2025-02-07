# Natural Language Processing (NLP) Notes

**NLTK (Natural Language Toolkit)** - open source Python library for working with human language data
- Released in 2001

**Spacy** - open source Python library for NLP
- Released in 2015
- Faster than NLTK

## Spacy

**Install**: `pip install spacy`

# Run Book

Run book for Udemy course "Natural Language Processing with Python" by Jose Portilla

(Had python as an alias for python3 and pip as an alias for pip3)
(Ran on macOS in VSCode and its integrated .zsh terminal)

1. Created and navigated to directory
2. Created virtual environment: `python -m venv venv`
3. Activated virtual environment: `source venv/bin/activate`
4. Installed Spacy: `pip install spacy`
5. Downloaded English language library: `python -m spacy download en`
6. Created a new Jupyter notebook
7. Checked jupyter installation: `jupyter --version`
   1. zsh: command not found: jupyter
8. Installed jupyter: `pip install jupyter`
9. Located python interpreter: `which python3` (which python just told me that it was an alias for python3)
9. ~~Set VSCode python interpreter to the one found above~~
10. VSCode refused to use that interpreter, possibly due to the path or iCloud
11. Set the in-editor python interpreter to one it recommended (a Python 3.9 version in /usr/bin/python3)

## Gotchas

1. VSCode couldn't figure out the path to the python interpreter for I specifically made to avoid annoying Python version issues
2. VSCode found 3 different existing versions of Python on a machine where I have intentionally tried to avoid global Python conflicts
3. Tutorial didn't explain how to get Jupyter working
4. Needed to install ipykernel in addition to jupyter for no clear reason
5. Got update pip warning, included line to update pip, still got update pip warning
6. Illegible warning trying to install spacy:

/Users/joelbreit/Library/Python/3.9/lib/python/site-packages/urllib3/__init__.py:35: NotOpenSSLWarning: urllib3 v2 only supports OpenSSL 1.1.1+, currently the 'ssl' module is compiled with 'LibreSSL 2.8.3'. See: https://github.com/urllib3/urllib3/issues/3020
  warnings.warn(

7. `Can't find model 'en_core_web_sm'` after all of the above and trying to run literally the first line of code in the tutorial

## Core Tasks

Module 2:
- Text classification
- Representation learning

Module 3:
- Language models
- Conditional language models

Module 4:
- Sequnce labeling
- Syntactic parsing

Module 5:
- Machine translation
- Speech recognition and synthesis
- Chatbots
- Information retrieval