// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CCC20200701.Models
{
    public class ListIntervalAgentReportResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<ListIntervalAgentReportResponseBodyData> Data { get; set; }
        public class ListIntervalAgentReportResponseBodyData : TeaModel {
            [NameInMap("Inbound")]
            [Validation(Required=false)]
            public ListIntervalAgentReportResponseBodyDataInbound Inbound { get; set; }
            public class ListIntervalAgentReportResponseBodyDataInbound : TeaModel {
                [NameInMap("AverageHoldTime")]
                [Validation(Required=false)]
                public float? AverageHoldTime { get; set; }
                [NameInMap("AverageRingTime")]
                [Validation(Required=false)]
                public float? AverageRingTime { get; set; }
                [NameInMap("AverageTalkTime")]
                [Validation(Required=false)]
                public float? AverageTalkTime { get; set; }
                [NameInMap("AverageWorkTime")]
                [Validation(Required=false)]
                public float? AverageWorkTime { get; set; }
                [NameInMap("CallsAttendedTransferIn")]
                [Validation(Required=false)]
                public long? CallsAttendedTransferIn { get; set; }
                [NameInMap("CallsAttendedTransferOut")]
                [Validation(Required=false)]
                public long? CallsAttendedTransferOut { get; set; }
                [NameInMap("CallsBlindTransferIn")]
                [Validation(Required=false)]
                public long? CallsBlindTransferIn { get; set; }
                [NameInMap("CallsBlindTransferOut")]
                [Validation(Required=false)]
                public long? CallsBlindTransferOut { get; set; }
                [NameInMap("CallsHandled")]
                [Validation(Required=false)]
                public long? CallsHandled { get; set; }
                [NameInMap("CallsHold")]
                [Validation(Required=false)]
                public long? CallsHold { get; set; }
                [NameInMap("CallsOffered")]
                [Validation(Required=false)]
                public long? CallsOffered { get; set; }
                [NameInMap("CallsRinged")]
                [Validation(Required=false)]
                public long? CallsRinged { get; set; }
                [NameInMap("HandleRate")]
                [Validation(Required=false)]
                public float? HandleRate { get; set; }
                [NameInMap("MaxHoldTime")]
                [Validation(Required=false)]
                public long? MaxHoldTime { get; set; }
                [NameInMap("MaxRingTime")]
                [Validation(Required=false)]
                public long? MaxRingTime { get; set; }
                [NameInMap("MaxTalkTime")]
                [Validation(Required=false)]
                public long? MaxTalkTime { get; set; }
                [NameInMap("MaxWorkTime")]
                [Validation(Required=false)]
                public long? MaxWorkTime { get; set; }
                [NameInMap("SatisfactionIndex")]
                [Validation(Required=false)]
                public float? SatisfactionIndex { get; set; }
                [NameInMap("SatisfactionRate")]
                [Validation(Required=false)]
                public float? SatisfactionRate { get; set; }
                [NameInMap("SatisfactionSurveysOffered")]
                [Validation(Required=false)]
                public long? SatisfactionSurveysOffered { get; set; }
                [NameInMap("SatisfactionSurveysResponded")]
                [Validation(Required=false)]
                public long? SatisfactionSurveysResponded { get; set; }
                [NameInMap("TotalHoldTime")]
                [Validation(Required=false)]
                public long? TotalHoldTime { get; set; }
                [NameInMap("TotalRingTime")]
                [Validation(Required=false)]
                public long? TotalRingTime { get; set; }
                [NameInMap("TotalTalkTime")]
                [Validation(Required=false)]
                public long? TotalTalkTime { get; set; }
                [NameInMap("TotalWorkTime")]
                [Validation(Required=false)]
                public long? TotalWorkTime { get; set; }
            };

            [NameInMap("Outbound")]
            [Validation(Required=false)]
            public ListIntervalAgentReportResponseBodyDataOutbound Outbound { get; set; }
            public class ListIntervalAgentReportResponseBodyDataOutbound : TeaModel {
                [NameInMap("AnswerRate")]
                [Validation(Required=false)]
                public float? AnswerRate { get; set; }
                [NameInMap("AverageDialingTime")]
                [Validation(Required=false)]
                public float? AverageDialingTime { get; set; }
                [NameInMap("AverageHoldTime")]
                [Validation(Required=false)]
                public float? AverageHoldTime { get; set; }
                [NameInMap("AverageRingTime")]
                [Validation(Required=false)]
                public float? AverageRingTime { get; set; }
                [NameInMap("AverageTalkTime")]
                [Validation(Required=false)]
                public float? AverageTalkTime { get; set; }
                [NameInMap("AverageWorkTime")]
                [Validation(Required=false)]
                public float? AverageWorkTime { get; set; }
                [NameInMap("CallsAnswered")]
                [Validation(Required=false)]
                public long? CallsAnswered { get; set; }
                [NameInMap("CallsAttendedTransferIn")]
                [Validation(Required=false)]
                public long? CallsAttendedTransferIn { get; set; }
                [NameInMap("CallsAttendedTransferOut")]
                [Validation(Required=false)]
                public long? CallsAttendedTransferOut { get; set; }
                [NameInMap("CallsBlindTransferIn")]
                [Validation(Required=false)]
                public long? CallsBlindTransferIn { get; set; }
                [NameInMap("CallsBlindTransferOut")]
                [Validation(Required=false)]
                public long? CallsBlindTransferOut { get; set; }
                [NameInMap("CallsDialed")]
                [Validation(Required=false)]
                public long? CallsDialed { get; set; }
                [NameInMap("CallsHold")]
                [Validation(Required=false)]
                public long? CallsHold { get; set; }
                [NameInMap("CallsRinged")]
                [Validation(Required=false)]
                public long? CallsRinged { get; set; }
                [NameInMap("MaxDialingTime")]
                [Validation(Required=false)]
                public long? MaxDialingTime { get; set; }
                [NameInMap("MaxHoldTime")]
                [Validation(Required=false)]
                public long? MaxHoldTime { get; set; }
                [NameInMap("MaxRingTime")]
                [Validation(Required=false)]
                public long? MaxRingTime { get; set; }
                [NameInMap("MaxTalkTime")]
                [Validation(Required=false)]
                public long? MaxTalkTime { get; set; }
                [NameInMap("MaxWorkTime")]
                [Validation(Required=false)]
                public long? MaxWorkTime { get; set; }
                [NameInMap("SatisfactionIndex")]
                [Validation(Required=false)]
                public float? SatisfactionIndex { get; set; }
                [NameInMap("SatisfactionRate")]
                [Validation(Required=false)]
                public float? SatisfactionRate { get; set; }
                [NameInMap("SatisfactionSurveysOffered")]
                [Validation(Required=false)]
                public long? SatisfactionSurveysOffered { get; set; }
                [NameInMap("SatisfactionSurveysResponded")]
                [Validation(Required=false)]
                public long? SatisfactionSurveysResponded { get; set; }
                [NameInMap("TotalDialingTime")]
                [Validation(Required=false)]
                public long? TotalDialingTime { get; set; }
                [NameInMap("TotalHoldTime")]
                [Validation(Required=false)]
                public long? TotalHoldTime { get; set; }
                [NameInMap("TotalRingTime")]
                [Validation(Required=false)]
                public long? TotalRingTime { get; set; }
                [NameInMap("TotalTalkTime")]
                [Validation(Required=false)]
                public long? TotalTalkTime { get; set; }
                [NameInMap("TotalWorkTime")]
                [Validation(Required=false)]
                public long? TotalWorkTime { get; set; }
            };

            [NameInMap("Overall")]
            [Validation(Required=false)]
            public ListIntervalAgentReportResponseBodyDataOverall Overall { get; set; }
            public class ListIntervalAgentReportResponseBodyDataOverall : TeaModel {
                [NameInMap("AverageBreakTime")]
                [Validation(Required=false)]
                public float? AverageBreakTime { get; set; }
                [NameInMap("AverageHoldTime")]
                [Validation(Required=false)]
                public float? AverageHoldTime { get; set; }
                [NameInMap("AverageReadyTime")]
                [Validation(Required=false)]
                public float? AverageReadyTime { get; set; }
                [NameInMap("AverageTalkTime")]
                [Validation(Required=false)]
                public float? AverageTalkTime { get; set; }
                [NameInMap("AverageWorkTime")]
                [Validation(Required=false)]
                public float? AverageWorkTime { get; set; }
                [NameInMap("FirstCheckInTime")]
                [Validation(Required=false)]
                public long? FirstCheckInTime { get; set; }
                [NameInMap("LastCheckoutTime")]
                [Validation(Required=false)]
                public long? LastCheckoutTime { get; set; }
                [NameInMap("MaxBreakTime")]
                [Validation(Required=false)]
                public long? MaxBreakTime { get; set; }
                [NameInMap("MaxHoldTime")]
                [Validation(Required=false)]
                public long? MaxHoldTime { get; set; }
                [NameInMap("MaxReadyTime")]
                [Validation(Required=false)]
                public long? MaxReadyTime { get; set; }
                [NameInMap("MaxTalkTime")]
                [Validation(Required=false)]
                public long? MaxTalkTime { get; set; }
                [NameInMap("MaxWorkTime")]
                [Validation(Required=false)]
                public long? MaxWorkTime { get; set; }
                [NameInMap("OccupancyRate")]
                [Validation(Required=false)]
                public float? OccupancyRate { get; set; }
                [NameInMap("SatisfactionIndex")]
                [Validation(Required=false)]
                public float? SatisfactionIndex { get; set; }
                [NameInMap("SatisfactionRate")]
                [Validation(Required=false)]
                public float? SatisfactionRate { get; set; }
                [NameInMap("SatisfactionSurveysOffered")]
                [Validation(Required=false)]
                public long? SatisfactionSurveysOffered { get; set; }
                [NameInMap("SatisfactionSurveysResponded")]
                [Validation(Required=false)]
                public long? SatisfactionSurveysResponded { get; set; }
                [NameInMap("TotalBreakTime")]
                [Validation(Required=false)]
                public long? TotalBreakTime { get; set; }
                [NameInMap("TotalCalls")]
                [Validation(Required=false)]
                public long? TotalCalls { get; set; }
                [NameInMap("TotalHoldTime")]
                [Validation(Required=false)]
                public long? TotalHoldTime { get; set; }
                [NameInMap("TotalLoggedInTime")]
                [Validation(Required=false)]
                public long? TotalLoggedInTime { get; set; }
                [NameInMap("TotalReadyTime")]
                [Validation(Required=false)]
                public long? TotalReadyTime { get; set; }
                [NameInMap("TotalTalkTime")]
                [Validation(Required=false)]
                public long? TotalTalkTime { get; set; }
                [NameInMap("TotalWorkTime")]
                [Validation(Required=false)]
                public long? TotalWorkTime { get; set; }
            };

            [NameInMap("StatsTime")]
            [Validation(Required=false)]
            public long? StatsTime { get; set; }

        }

        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
