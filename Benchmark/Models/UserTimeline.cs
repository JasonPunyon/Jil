﻿using ProtoBuf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Benchmark.Models
{
    enum UserTimelineType : byte
    {
        commented = 1,
        asked = 2,
        answered = 3,
        badge = 4,
        revision = 5,
        accepted = 6,
        reviewed = 7,
        suggested = 8
    }

    [ProtoContract]
    class UserTimeline : IGenericEquality<UserTimeline>
    {
        [ProtoMember(1)]
        public DateTime? creation_date { get; set; }
        [ProtoMember(2)]
        public PostType? post_type { get; set; }
        [ProtoMember(3)]
        public UserTimelineType? timeline_type { get; set; }
        [ProtoMember(4)]
        public int? user_id { get; set; }
        [ProtoMember(5)]
        public int? post_id { get; set; }
        [ProtoMember(6)]
        public int? comment_id { get; set; }
        [ProtoMember(7)]
        public int? suggested_edit_id { get; set; }
        [ProtoMember(8)]
        public int? badge_id { get; set; }
        [ProtoMember(9)]
        public string title { get; set; }
        [ProtoMember(10)]
        public string detail { get; set; }
        [ProtoMember(11)]
        public string link { get; set; }

        public bool Equals(UserTimeline obj)
        {
            return
                this.badge_id.TrueEquals(obj.badge_id) &&
                this.comment_id.TrueEquals(obj.comment_id) &&
                this.creation_date.TrueEquals(obj.creation_date) &&
                this.detail.TrueEqualsString(obj.detail) &&
                this.link.TrueEqualsString(obj.link) &&
                this.post_id.TrueEquals(obj.post_id) &&
                this.post_type.TrueEquals(obj.post_type) &&
                this.suggested_edit_id.TrueEquals(obj.suggested_edit_id) &&
                this.timeline_type.TrueEquals(obj.timeline_type) &&
                this.title.TrueEqualsString(obj.title) &&
                this.user_id.TrueEquals(obj.user_id);
        }
    }
}
