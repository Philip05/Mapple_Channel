import RPi.GPIO as GPIO
from time import sleep

# The script as below using BCM GPIO 00..nn numbers
GPIO.setmode(GPIO.BCM)

# Set relay pins as output
GPIO.setup(23, GPIO.OUT)
#GPIO.setup(23, GPIO.OUT)
    
# Turn all relays ON
GPIO.output(23, GPIO.HIGH)
#GPIO.output(23, GPIO.HIGH)
# Sleep for 5 seconds
  
