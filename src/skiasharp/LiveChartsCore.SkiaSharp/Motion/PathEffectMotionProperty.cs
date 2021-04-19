﻿// The MIT License(MIT)
//
// Copyright(c) 2021 Alberto Rodriguez Orozco & LiveCharts Contributors
//
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
//
// The above copyright notice and this permission notice shall be included in all
// copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
// SOFTWARE.

using LiveChartsCore.Motion;
using LiveChartsCore.SkiaSharpView.Motion.Composed;

namespace LiveChartsCore.SkiaSharpView.Motion
{
    /// <summary>
    /// A property that defines path effects transitions to enable animations.
    /// </summary>
    public class PathEffectMotionProperty : MotionProperty<PathEffect>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PathEffectMotionProperty"/> class.
        /// </summary>
        /// <param name="propertyName">Name of the property.</param>
        public PathEffectMotionProperty(string propertyName)
            : base(propertyName)
        {

        }

        /// <inheritdoc cref="OnGetMovement(float)" />
        protected override PathEffect OnGetMovement(float progress)
        {
            if (fromValue == null && toValue == null) return null;
            if (toValue == null && fromValue != null) toValue = fromValue;
            if (fromValue == null && toValue != null) fromValue = toValue;
            return toValue.InterpolateFrom(fromValue, progress);
        }
    }
}
