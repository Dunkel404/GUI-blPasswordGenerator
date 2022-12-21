namespace PasswordGenerator.Tools
{
    public static class FlipColors
    {

        /// <summary>
        /// The FlipAllColors method inverts all colors in the image, as the name implies,
        /// while the FlipRedColors, FlipGreenColors, and FlipBlueColors methods
        /// invert the values of red, green, and blue, respectively.
        /// </summary>

        public static Bitmap InvertAllColors(Bitmap ImageToInvert)
        {
            using (ImageToInvert)
            {
                // Loop through the Y coordinates of the image.
                Parallel.For(0, ImageToInvert.Height, y =>
                {
                    // Loop through the X coordinates of the image.
                    for (int x = 0; x < ImageToInvert.Width; x++)
                    {
                        // Get the pixel at the current position.
                        Color pixel = ImageToInvert.GetPixel(x, y);

                        // Invert each color component
                        byte invertedRed = InvertColorComponent(pixel.R);
                        byte invertedGreen = InvertColorComponent(pixel.G);
                        byte invertedBlue = InvertColorComponent(pixel.B);

                        // Create a new Color with the inverted components
                        Color invertedColor = Color.FromArgb(pixel.A, invertedRed, invertedGreen, invertedBlue);

                        // Set the inverted color back to the image
                        ImageToInvert.SetPixel(x, y, invertedColor);
                    }
                });

                return ImageToInvert;
            }
        }

        public static Bitmap InvertRedColors(Bitmap ImageToInvert)
        {
            using (ImageToInvert)
            {
                Parallel.For(0, ImageToInvert.Height, y =>
                {
                    for (int x = 0; x < ImageToInvert.Width; x++)
                    {
                        Color pixel = ImageToInvert.GetPixel(x, y);

                        // Invert Red color component
                        byte invertedRed = InvertColorComponent(pixel.R);

                        Color invertedColor = Color.FromArgb(pixel.A, invertedRed, pixel.G, pixel.B);

                        ImageToInvert.SetPixel(x, y, invertedColor);
                    }
                });

                return ImageToInvert;
            }
        }

        public static Bitmap FlipGreenColors(Bitmap ImageToInvert)
        {
            using (ImageToInvert)
            {
                Parallel.For(0, ImageToInvert.Height, y =>
                {
                    for (int x = 0; x < ImageToInvert.Width; x++)
                    {
                        Color pixel = ImageToInvert.GetPixel(x, y);

                        // Invert Green color component
                        byte invertedGreen = InvertColorComponent(pixel.G);


                        Color invertedColor = Color.FromArgb(pixel.A, pixel.R, invertedGreen, pixel.B);

                        ImageToInvert.SetPixel(x, y, invertedColor);
                    }
                });

                return ImageToInvert;
            }
        }

        public static Bitmap FlipBlueColors(Bitmap ImageToInvert)
        {
            using (ImageToInvert)
            {
                Parallel.For(0, ImageToInvert.Height, y =>
                {
                    for (int x = 0; x < ImageToInvert.Width; x++)
                    {
                        Color pixel = ImageToInvert.GetPixel(x, y);

                        // Invert Green color component.
                        byte invertedBlue = InvertColorComponent(pixel.B);

                        Color invertedColor = Color.FromArgb(pixel.A, invertedBlue, pixel.G, invertedBlue);

                        ImageToInvert.SetPixel(x, y, invertedColor);
                    }
                });

                return ImageToInvert;
            }
        }

        public static byte InvertColorComponent(byte colorComponent)
        {
            //invert the provided component color.
            return (byte)~colorComponent;
        }

    }
}
