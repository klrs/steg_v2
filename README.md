# steg_v2

A simple (and currently very barebones) program that hides a file to an image using LSB steganography.
The extracting process does not currently know how much to extract. So extracting anything else than text may prove to be difficult unless you know
the exact byte size of the file.

INSTRUCTIONS:
There are two modes, Hide and Extract mode.
Hide mode hides a file of your choosing to a image to your choosing. It outputs a bmp image.
Extract mode extracts a raw file from the .bmp image of your choosing.

Hide mode:
1. Choose input image by clicking browse on the right. This is the image you are going to hide your file.
The image has some limitations but the program should notify you if the .bmp isn't valid.
2. Choose input file. This is the file you are going to hide in an image. NOTE: While steg_v2 supports any kind of file. Text files (.txt) are preferred.
3. Choose output image location and name. Add .bmp to the end.
4. Press Hide. "Done!" text will appear next to Hide button in case the process was successful.

Extract mode:
1. Choose input image of your choosing. It has to be .bmp format.
2. Choose output file of your choosing and name it. This is the file where your data extracted from the image is saved.
3. Press Extract. "Done!" text will appear next to Extract button in case the process was successful.
