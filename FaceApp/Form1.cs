using Emgu.CV;
using Emgu.CV.CvEnum;
using Emgu.CV.Structure;

namespace FaceApp
{
    public partial class FaceDetectionApp : Form
    {
        VideoCapture capture;
        CascadeClassifier faceDetector;
        Mat frame;
        public FaceDetectionApp()
        {
            InitializeComponent();
        }

        public void metot()
        {
            // WebCam'den görüntü al
            capture.Read(frame);


            // Gri tonlamaya çevir
            Mat grayFrame = new Mat();
            CvInvoke.CvtColor(frame, grayFrame, ColorConversion.Bgr2Gray);

            // Yüzleri tespit et
            Rectangle[] facesDetected = faceDetector.DetectMultiScale(
                grayFrame,
                1.1,
                10,
                new Size(20, 20),
                Size.Empty);

            // Tespit edilen yüzlerin etrafýna dikdörtgen çiz
            foreach (Rectangle face in facesDetected)
            {
                CvInvoke.Rectangle(frame, face, new MCvScalar(0, 255, 0), 2);
            }

            pctrBox1.Image = frame.ToBitmap();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            capture = new VideoCapture(0);
            if (!capture.IsOpened)
            {
                Console.WriteLine("Webcam açýlamadý.");
                return;
            }

            faceDetector = new CascadeClassifier("haarcascade_frontalface_default.xml");
            frame = new Mat();
            timer1.Start();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            capture.Dispose();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            metot();
        }
    }
}
