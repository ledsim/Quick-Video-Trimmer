# Quick-Video-Trimmer
Quickly cut large videos into smaller parts.

This app works as a graphical extension for FFmpeg. Its sole purpose is to split videos into smaller pieces.  
Because it relies directly on FFmpeg and requires almost no user interaction, trimming is very fast and has low performance requirements.

A common use case is splitting a large video so that it fits into FAT32 storage. (so that you can transfer a movie to a USB drive and play it on a set-top box for example :D )
Since FAT32 doesn’t support files larger than 4 GB, simply splitting the video solves the problem! ヽ(・∀・)ﾉ

# Compatibility (what you need)
- 64 bit OS will work (32 bit untested)
- Windows 7+
- .NET 4.6+
- FFmpeg 7.0 + (earlier untested)

# How to set up?
Place "ffmpeg.exe" in the "ffmpeg" folder. 
The folder tree should now look like this:

\[app-path]
     \ffmpeg
          ffmpeg.exe
     Microsoft.WindowsAPICodePack.dll
     Microsoft.WindowsAPICodePack.Shell.dll
     Quick Video Trimmer.exe
     Quick Video Trimmer.exe.config
     Quick Video Trimmer.exe.manifest

That's it! Happy trimming :D.


Free to use & modify — just credit me (MIT)
