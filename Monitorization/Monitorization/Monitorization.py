import picamera

with picamera.PiCamera() as camera:
    camera.resolution = (640, 480)
    camera.start_recording('my_video.h264', format = 'h264', quality=25)
    camera.wait_recording(10)
    camera.stop_recording()