using System;

/*
 * Namespace: InsertRecordMvcCore
 * Name class: ErrorViewModel
 * Author: System
 */

namespace InsertRecordMvcCore.Models
{
    public class ErrorViewModel
    {
        public string RequestId { get; set; }

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }
}
