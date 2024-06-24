![Static Badge](https://img.shields.io/badge/Verson-2022.3.22f1-5300EB?style=for-the-badge&logo=Unity)
![Static Badge](https://img.shields.io/badge/Version-1.0.0-blue?style=for-the-badge)
[![License: MIT](https://img.shields.io/badge/License-MIT-yellow.svg?style=for-the-badge)](https://opensource.org/licenses/MIT)

> [!IMPORTANT]
These are pretty much all made with the help of chat GPT when I was looking for a way to make the inspector look better in my [Unity-Planets](https://github.com/B0XEY/Unity-Planets) project.

# Project Overview
Welcome to the **Boxey-Attributes** for the Unity! This repository contains a collection of custom attributes designed to extend the functionality of the Unity game engine. These attributes aim to improve the workflow and enhance the development experience for Unity developers. By leveraging these attributes, developers can create more maintainable, readable, and efficient code and inspectors.

## Examples
### Button Attribute
Adds a button to the inspector to call a function
```c#
using Boxey.Attributes;
using UnityEngine;

public class Example : MonoBehaviour {
    [Button]
    private void Fuction() {
        Debug.Log("Value changed!");
    }
}
```
### Enum Buttons Attribute
Turns enums into buttons you can click and change between
```c#
using Boxey.Attributes;
using UnityEngine;

public class Example : MonoBehaviour {
    private enum Test {
        a,
        b,
        c
    }
    [SerializeField, EnumButtons] private Test testName;
}
```
### Foldable Inspector Attribute
Allows you to fold and unfold the inspector for a scriptable object for easy editing
```c#
using Boxey.Attributes;
using UnityEngine;

public class Example : MonoBehaviour {
    [SerializeField, FoldableInspector] private ScriptibleObject testName;
}
```
### Label Attribute
Allows you to change the label of a field or remove it when left blank.
```c#
using Boxey.Attributes;
using UnityEngine;

public class Example : MonoBehaviour {
    [SerializeField, Label("Custom Label")] private string testName;
    [SerializeField, Label] private String testName2; //Has no label
}
```
### Line Attribute
Draws a line in the editor that the user can edit the color and thickness of.
```c#
using Boxey.Attributes;
using UnityEngine;

public class Example : MonoBehaviour {
    [Header("Header"), Line]
    [SerializeField] private string testName;
    [Line(1.25f, 05f, 0.5f, 0.5f)]
    [SerializeField] private string testName2;
}
```
### On Changed Attribute
Calls the function when the value is edited or changed
```c#
using Boxey.Attributes;
using UnityEngine;

public class Example : MonoBehaviour {
    [SerializeField, OnChanged(nameof(Test))] private string testName;
    private void Test() {       
    }
}
```
### Required Attribute
Make sure the value is set. Useful when you need to make sure the feild is set.
```c#
using Boxey.Attributes;
using UnityEngine;

public class Example : MonoBehaviour {
    [SerializeField, Required] private string testName;
}
```
### Show If Attribute
Shows the field it is on when the bool you enter is true, hides the field when the bool is false.
```c#
using Boxey.Attributes;
using UnityEngine;

public class Example : MonoBehaviour {
    [SerializeField] private bool showData = true;
    [SerializeField, ShowIf("showData")] private string testName;
}
```
### Show Only Attribute
Useful when you want to show a value in the inspector but don't want to be able to edit it. Useful for debugging.
```c#
using Boxey.Attributes;
using UnityEngine;

public class Example : MonoBehaviour {
    [SerializeField, ShowOnly] private string testName;
}
```

## License
MIT License

Copyright (c) 2024 Boxey Dev

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all
copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
SOFTWARE.
