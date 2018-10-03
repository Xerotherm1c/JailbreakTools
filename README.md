# Xerotherm1c's JailbreakTools

Hola! I hope you enjoy browsing the source code and using the tools I create. More to come in the future.

# shshPatri0tS
shshPatri0tS is the first tool I'm releasing. The purpose is to automatically check for and download shsh2 blobs every single day (at a pseudo-random time) so that you don't have to constantly check and download blobs when they're available. Most recently, I missed the signing window for 11.3 and now I'm stuck with a non-jailbroken iPhone 6S. This tool was born out of my frustration with Apple. Just let us do what we want with the devices we purchased.

Special thanks to the open source contributions of the following projects that helped make shshPatri0tS possible:
- TSSSaver - https://github.com/TSSSaver/TSSSaver
- tsschecker - https://github.com/tihmstar/tsschecker
- noncestatistics - https://github.com/tihmstar/noncestatistics

# Features
- AutoFetch device info (automatically grabs the ECID, device type, model, board config, and any captured apnonces)
- Implemented Profile system so you can automatically (or manually) save the blobs of as many profiles as you'd like
- Very transparent file storage - open up a File Explorer directly to any saved resource the program uses via File -> Open
- Optionally toggle the visibility of raw output from the windowless programs that shshPatri0tS initiates (tsschecker & noncestatistics)

# Requirements
- Windows with .NET 4.5.2 (sorry, Mac users. Hey, maybe someone will port this to Mac - that'd be pretty cool.)

# Installation
- Download the contents of /bin
- Run shshPatri0tS.exe

Note: If you enable task scheduling (Scheduling -> Modify Autosaves) and then you move the program to a different directory, all you need to do is disable the task scheduling and then re-enable it from within the program running from the new location. shshPatri0tS will delete the old scheduled task when you disable this feature, and then upon re-enabling it the program will create a new task with the same name that points to the correct executable path.

# Final Remarks
Still with me? Sweet. I've been a loyal jailbreaker since I first got a first-gen iPod Touch running iOS 1.1.2 and as to be expected, all of my jailbreak development will be forever free. If you'd like to support development, please head over to my Patreon page at https://www.patreon.com/Xerotherm1c

And if you find any bugs, please please please! Create an issue here on Github and I will fix it as soon as possible.

Here's to pushing jailbreak development forward with a resurge in motivation. Cheers!
