# Mouse Automation Tool

AutoMouseActioner is a simple and efficient Windows application built with .NET 8. It automates mouse cursor movement and simulates key presses at regular intervals, making it useful for keeping your system active. The app includes a user-friendly interface with start/stop buttons and supports customizable global hotkeys for convenient control.
---

## Features

* **Automated Mouse Movement:** 
    * Automatically moves the mouse cursor to a specified position or pattern.
    * Simulates `Shift` key presses concurrently with mouse movement.
    * Configurable time interval for movement and key press events.
* **Hotkey Support:**
    * **Ctrl + Shift + S:** Starts the automated mouse movement and Shift key presses.
    * **Ctrl + Shift + T:** Stops the automated mouse movement and key press simulation.
    * **Ctrl + Shift + E:** Exits the application.
* **User Interface:**
    * Intuitive Windows Forms interface with a `Start` and `Stop` button for manual control.

## Technical Details

* Developed using .NET 8.
* Utilizes the `user32.dll` library for mouse cursor control and key press simulation.
* Employs event handlers and `IntPtr` for efficient hotkey handling.

## Usage

1. **Compile and Run:** Build the solution and execute the application.
2. **Start/Stop Automation:** 
    * Click the "Start" button in the UI to initiate automated mouse movement and Shift key presses.
    * Click the "Stop" button to halt the process.
3. **Hotkeys:**
    * **Ctrl + Shift + S:** Start the automation.
    * **Ctrl + Shift + T:** Stop the automation.
    * **Ctrl + Shift + E:** Exit the application.

---
### Prerequisites

- **.NET Runtime**: .NET 8 Runtime installed ([Download Here](https://dotnet.microsoft.com/en-us/download))
- A Windows operating system (Windows 10/11 recommended).

## Installation

1. **Clone the Repository**:
   ```bash
   git clone https://github.com/emranmho/AutoMouseAction.git
   cd AutoMouseAction

2. Build and run the project:
   * Using Visual Studio:
      * Open the solution file and build the project.
      * Run the application.
   * Using Command Line:     
     ```bash
     dotnet build
     dotnet run

## Acknowledgements
  *Microsoft Docs: For detailed information on user32.dll and hotkey handling in Windows.
