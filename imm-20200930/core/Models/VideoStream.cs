// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imm20200930.Models
{
    public class VideoStream : TeaModel {
        /// <summary>
        /// Index
        /// </summary>
        [NameInMap("Index")]
        [Validation(Required=false)]
        public long? Index { get; set; }

        /// <summary>
        /// Language
        /// </summary>
        [NameInMap("Language")]
        [Validation(Required=false)]
        public string Language { get; set; }

        /// <summary>
        /// CodecName
        /// </summary>
        [NameInMap("CodecName")]
        [Validation(Required=false)]
        public string CodecName { get; set; }

        /// <summary>
        /// CodecLongName
        /// </summary>
        [NameInMap("CodecLongName")]
        [Validation(Required=false)]
        public string CodecLongName { get; set; }

        /// <summary>
        /// Profile
        /// </summary>
        [NameInMap("Profile")]
        [Validation(Required=false)]
        public string Profile { get; set; }

        /// <summary>
        /// CodecTimeBase
        /// </summary>
        [NameInMap("CodecTimeBase")]
        [Validation(Required=false)]
        public string CodecTimeBase { get; set; }

        /// <summary>
        /// CodecTagString
        /// </summary>
        [NameInMap("CodecTagString")]
        [Validation(Required=false)]
        public string CodecTagString { get; set; }

        /// <summary>
        /// CodecTag
        /// </summary>
        [NameInMap("CodecTag")]
        [Validation(Required=false)]
        public string CodecTag { get; set; }

        /// <summary>
        /// Width
        /// </summary>
        [NameInMap("Width")]
        [Validation(Required=false)]
        public long? Width { get; set; }

        /// <summary>
        /// Height
        /// </summary>
        [NameInMap("Height")]
        [Validation(Required=false)]
        public long? Height { get; set; }

        /// <summary>
        /// HasBFrames
        /// </summary>
        [NameInMap("HasBFrames")]
        [Validation(Required=false)]
        public string HasBFrames { get; set; }

        /// <summary>
        /// SampleAspectRatio
        /// </summary>
        [NameInMap("SampleAspectRatio")]
        [Validation(Required=false)]
        public string SampleAspectRatio { get; set; }

        /// <summary>
        /// DisplayAspectRatio
        /// </summary>
        [NameInMap("DisplayAspectRatio")]
        [Validation(Required=false)]
        public string DisplayAspectRatio { get; set; }

        /// <summary>
        /// PixelFormat
        /// </summary>
        [NameInMap("PixelFormat")]
        [Validation(Required=false)]
        public string PixelFormat { get; set; }

        /// <summary>
        /// Level
        /// </summary>
        [NameInMap("Level")]
        [Validation(Required=false)]
        public long? Level { get; set; }

        /// <summary>
        /// FrameRate
        /// </summary>
        [NameInMap("FrameRate")]
        [Validation(Required=false)]
        public float? FrameRate { get; set; }

        /// <summary>
        /// AverageFrameRate
        /// </summary>
        [NameInMap("AverageFrameRate")]
        [Validation(Required=false)]
        public float? AverageFrameRate { get; set; }

        /// <summary>
        /// TimeBase
        /// </summary>
        [NameInMap("TimeBase")]
        [Validation(Required=false)]
        public string TimeBase { get; set; }

        /// <summary>
        /// StartTime
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public float? StartTime { get; set; }

        /// <summary>
        /// Duration
        /// </summary>
        [NameInMap("Duration")]
        [Validation(Required=false)]
        public float? Duration { get; set; }

        /// <summary>
        /// Bitrate
        /// </summary>
        [NameInMap("Bitrate")]
        [Validation(Required=false)]
        public long? Bitrate { get; set; }

        /// <summary>
        /// FrameCount
        /// </summary>
        [NameInMap("FrameCount")]
        [Validation(Required=false)]
        public long? FrameCount { get; set; }

    }

}