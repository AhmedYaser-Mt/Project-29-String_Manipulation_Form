# ✏️ Project 29 — String Manipulation Form

> A live-updating C# string toolkit — every operation (case, trim, replace, extract) works on the current input and writes instantly to the output, with real-time character count, word count, first word, and last word tracking as you type.

---

<img width="550" height="450" alt="image" src="https://github.com/user-attachments/assets/5ceb44a4-5cce-43d3-bd55-022ccc7dacca" />


---

## 🚀 Project Overview

Fifth project in the WinForms self-practice series.

Same four controls. Bigger problem.

This project is a full string operations toolkit.

Enter any text. The form responds immediately — character count, word count, first word, and last word all update on every keystroke without pressing a single button.

From there, every operation writes its result to the output box:

Case it, trim it, replace inside it, extract a part of it.

All through labels, text boxes, and buttons.

---

## 🏗️ Architecture Design

```
txtInput_TextChanged       (fires on every keystroke — no button needed)
 ├── FillInputInfo()
 │    ├── txtCharacters.Text = txtInput.TextLength
 │    ├── txtWords.Text     = word count (with trailing space handling)
 │    ├── txtFirstWord.Text = first word
 │    └── txtLastWord.Text  = last word (edge case: trailing space)
 └── FillOutput()           ← output always mirrors input

btnCaseOperations_Click    (shared by To Upper / To Lower / As Input)
 └── switch (Button.Tag)
      ├── "ToUpper"  → ToUpper()
      ├── "ToLower"  → ToLower()
      └── "AsInput"  → AsInput()

btnTransformations_Click   (shared by Trim / Trim Start / Trim End / Remove Spaces)
 └── switch (Button.Tag)
      ├── "Trim"         → Trim()
      ├── "TrimStart"    → TrimStart()
      ├── "TrimEnd"      → TrimEnd()
      └── "RemoveSpaces" → RemoveSpaces()

bttnReplace_Click          (shared by Replace All / Replace First)
 └── IsValidReplaceInfo()  ← guard: text must exist AND be found in input
      ├── "ReplaceAll"   → String.Replace()
      └── "ReplaceFirst" → IndexOf() + Remove() + Insert()

btnGetSubstring_Click
 └── IsValidExtractInfo()  ← guard: start in range + length in range
      └── GetSubstring()  → Substring(start, length)

btnOutputOperations_Click  (shared by Copy Output / Clear Output / Clear All)
 └── switch (Button.Tag)
      ├── "CopyOutput"  → SelectAll() + Copy()
      ├── "ClearOutput" → ClearOutputSection()
      └── "ClearAll"    → ClearAllTextboxes()

btnClearInput_Click
 └── ClearInputSection()
```

---

## ⚙️ Core Functionalities

| Section | Operation | Description |
|---|---|---|
| **Input** | Live info | Characters · Words · First word · Last word — updates on every keystroke |
| **Case** | To Upper | `ToUpper()` |
| **Case** | To Lower | `ToLower()` |
| **Case** | As Input | Copy input to output with no changes |
| **Transform** | Trim / Trim Start / Trim End | Remove whitespace from both ends / left / right |
| **Transform** | Remove Spaces | Remove all spaces (not just edges) |
| **Transform** | Replace All | Replace every occurrence with the new value |
| **Transform** | Replace First | Replace only the first occurrence |
| **Extract** | Get Substring | Extract a portion by start index and length |
| **Output** | Copy Output | Select all + copy to clipboard |
| **Output** | Clear Output | Empty the output box |
| **Output** | Clear All | Clear every TextBox on the form |

---

## 🧠 Design Decisions Worth Noting

### Live sync via TextChanged

There is no "Apply" button for basic display.

```csharp
private void txtInput_TextChanged(object sender, EventArgs e)
{
    FillInputInfo();
    FillOutput();
}
```

Every keystroke fires this event — live character count, live word count, and the output box always mirrors the input. Case and transform operations then override the output directly.

---

### Smart word count with trailing space handling

A naive `Split(' ').Length` overcounts when the input ends with a space.

The code handles this explicitly:

```csharp
if (txtInput.Text[txtInput.TextLength - 1] == ' ')
{
    txtWords.Text = (SplitedString.Length - 1).ToString();
    txtLastWord.Text = SplitedString[SplitedString.Length - 2];
}
```

"hello world " → 2 words, last word = "world". Not 3.

---

### Replace First vs Replace All

`Replace All` uses the built-in `String.Replace()` which replaces every occurrence.

`Replace First` is built manually using three steps:

```csharp
byte index = Convert.ToByte(txtInput.Text.IndexOf(txtFind.Text));
txtOutput.Text = txtInput.Text.Remove(index, txtFind.TextLength);
txtOutput.Text = txtOutput.Text.Insert(index, txtReplaceWith.Text);
```

`IndexOf` → find the position.
`Remove` → cut the original word out.
`Insert` → put the new word in.

If you wrote `Replace(find, replaceWith)` for Replace First, it would replace ALL occurrences. This implementation targets only the first one.

---

### Tag-based shared event handlers

Instead of writing a separate Click handler for every button, groups of buttons share one handler via the `Tag` property:

- `btnCaseOperations_Click` → handles 3 buttons
- `btnTransformations_Click` → handles 4 buttons
- `bttnReplace_Click` → handles 2 buttons
- `btnOutputOperations_Click` → handles 3 buttons

12 buttons. 4 handlers.

---

### Granular clear by section

```csharp
private void ClearInputSection()    // clears input + info TextBoxes
private void ClearOutputSection()   // clears output only
private void ClearExtractSection()  // clears Start + Length
private void ClearTransformSection()// clears Find + Replace With
private void ClearAllTextboxes()    // calls all four
```

Each section owns its own clear function. `ClearAll` is just calling all four of them.

---

### Extract validation chain

Before running `GetSubstring()`, three conditions must all pass:

```csharp
!IsExtractSectionEmpty()   // both fields have content
&& !IsInputTextboxEmpty()  // there is text to extract from
&& IsValidStartIndex()     // 0 ≤ start < text length
&& IsValidSubstringLength()// length ≤ (text length - start)
```

If any condition fails, nothing happens — no crash, no partial output.

---

## 🛠️ Tech Stack

| | |
|---|---|
| **Language** | C# |
| **Framework** | .NET Framework |
| **UI** | Windows Forms (WinForms) |
| **IDE** | Visual Studio |
| **Type** | Desktop Application |
| **Controls Used** | Form, Label, TextBox, Button |

---

## 📦 Practice Project Series

| Project | Application |
|---|---|
| **Project 25 — Tax Calculator** | Tax computation + session history |
| **Project 26 — Text Encryption** | Caesar Cipher encrypt/decrypt |
| **Project 27 — Password Generator** | GUID + Key + Password generator |
| **Project 28 — Age Calculator** | Full age breakdown with time lived |
| **Project 29 — String Manipulation** *(you are here)* | Live string operations toolkit |
| More projects | Next control groups 🔄 |

---

## 🏁 Course & Milestone Context

- ✅ Course 14 — C# Level 1 (Stage Two, in progress)
- ✅ Fifth project in the WinForms self-practice series
- ✅ Part of the **Programming Advices Roadmap** — Stage Two

---

## 🙏 Gratitude

Thank you to:

- **[Programming Advices Platform](https://programmingadvices.com)**

- **[Dr. Mohammed Abu-Hadhoud](https://programmingadvices.com)**

---

## 🔥 What's Next

Next control group.

Next project.
