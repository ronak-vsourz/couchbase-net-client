﻿using System;
using Newtonsoft.Json.Linq;

namespace Couchbase.Search.Queries.Range
{
    /// <summary>
    /// The term range query finds documents containing a string value in the specified field within the specified range.
    /// Either min or max can be omitted, but not both.
    /// </summary>
    public class TermRangeQuery : FtsQueryBase
    {
        private readonly string _term;
        private string _min;
        private bool _minInclusive = true;
        private string _max;
        private bool _maxInclusive = false;
        private string _field;

        public TermRangeQuery(string term)
        {
            if (string.IsNullOrWhiteSpace(term))
            {
                throw new ArgumentException("term cannot be null or empty");
            }

            _term = term;
        }

        public TermRangeQuery Min(string min, bool inclusive = true)
        {
            _min = min;
            _minInclusive = inclusive;
            return this;
        }

        public TermRangeQuery Max(string max, bool inclusive = false)
        {
            _max = max;
            _maxInclusive = inclusive;
            return this;
        }

        public TermRangeQuery Field(string field)
        {
            _field = field;
            return this;
        }

        public override JObject Export()
        {
            if (string.IsNullOrWhiteSpace(_min) && string.IsNullOrWhiteSpace(_max))
            {
                throw new InvalidOperationException("either min or max must be specified");
            }

            var json = base.Export();
            json.Add("term", _term);
            if (!string.IsNullOrWhiteSpace(_min))
            {
                json.Add("min", _min);
                json.Add("inclusive_min", _minInclusive);
            }
            if (!string.IsNullOrWhiteSpace(_max))
            {
                json.Add("max", _max);
                json.Add("inclusive_max", _maxInclusive);
            }
            if (!string.IsNullOrWhiteSpace(_field))
            {
                json.Add("field", _field);
            }

            return json;
        }
    }
}
