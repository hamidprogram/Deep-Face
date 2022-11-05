# Required packages
import cv2
from deepface import DeepFace
import numpy as np
import json
import os
#-----------------------------------------

# Read and delete input file
fp = open('input.json','r')
data = fp.read()
fp.close()
os.remove('input.json')
#-----------------------------------------

# Convert JSON file to string and sread image path
image_path = json.loads(data)['ImagePath']
#-----------------------------------------

# Analyze image from input image path with deep face package
analyze = DeepFace.analyze(image_path, actions=['age','emotion'])
#-----------------------------------------

# Dump the output in a dictionary
info = {'Age':analyze['age'] , 'Emotion':analyze['emotion']}
#-----------------------------------------

# Convert dictionary to JSON file and save file
f = open('output.json','x')
f.write(json.dumps(info))
f.close()
#-----------------------------------------