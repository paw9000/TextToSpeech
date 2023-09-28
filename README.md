# TextToSpeech

MacOS has an accessibility option to have highlighted text from any applicaiton spoken aloud by pressing Option-Esc.  Windows would seem to lack similar functionality.  This project was an attempt to cover that gap.

I searched the net for existing programs to do text to speech on Windows, the options I found seemed to have these flaws I wished to avoid, they:
- Cost money
- Would send the text you wanted read over the internet to an external service, and send the sound file for it back.
- Require you to paste the text into an external app before it could be read.
- Consumed excessive system resources, or were bundled with additional features I didn't need or want.

The goals of this project are to:
- Avoid sending any data over the internet so the app will operate offline.
- Minimize actions necessary to have your desired text read aloud.
- Expose options for voice selection, rate of reading, volume, and make a global configurable shortcut key to have text read aloud.

By default TextToSpeech is configured to use Alt-Y as a globally registered key combination you can use to read text present on the clipboard.  Without operating system involvement from Windows, I don't believe we would safely be able to get highlighted text for external apps to get feature parity with MacOS.  The extra step to copy the text to the clipboard first is a necessary step I don't see a safe way to avoid.

When you minmize the app it will Hide the app so you wont see it in your task bar, but will show up as a system tray icon.  It should like like a speech bubble with the text "Hi!" in it.  You can either double click it, or right click it and select "Setup..." to show the UI for it.

I wrote this app using Microsoft Visual Studio Community 2022 and made judicious use of ChatGPT to help accelerate my understanding of how to write and deploy a Windows Forms App using the .NET Framework.

For me personally TextToSpeech helps me process information when I'm tired and haven't had my morning coffee yet, but I hope this app might help out people who perhaps have poor eyesight to continue to get access to text based information.