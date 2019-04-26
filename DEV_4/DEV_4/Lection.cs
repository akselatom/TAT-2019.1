
namespace DEV_4
{
    /// <summary>
    /// The lecture.
    /// </summary>
    public class Lecture : Materials
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="T:DEV_4.Lecture" /> class.
        /// </summary>
        public Lecture()
        {
            this.LectureText = "Lorem ipsum dolor sit amet, consectetur adipiscing elit.";
            this.Materials = new PresentationMaterial();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Lecture"/> class.
        /// </summary>
        /// <param name="lectureText">
        /// The lecture text.
        /// </param>
        /// <param name="material">
        /// The lecture material. Default value is null.
        /// </param>
        public Lecture(string lectureText, PresentationMaterial material = null)
        {
            this.LectureText = lectureText;
            this.Materials = material;
        }

        /// <summary>
        /// Gets field containing lecture text.
        /// </summary>
        public string LectureText { get; private set; }

        /// <summary>
        /// Gets <see cref="PresentationMaterial"/>
        /// </summary>
        public PresentationMaterial Materials { get; private set; }
    }
}