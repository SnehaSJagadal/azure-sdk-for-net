﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

namespace Azure.Communication.CallAutomation
{
    /// <summary><see cref="PlayEventResult"/> is returned from WaitForEvent of <see cref="PlayResult"/>.</summary>
    public class PlayEventResult
    {
        /// <summary>
        /// Indicates whether the returned event is considered successful or not.
        /// </summary>
        public bool IsSuccess { get; internal set; }

        /// <summary>
        /// <see cref="PlayCompleted"/> event will be returned once the play is completed successfully.
        /// </summary>
        public PlayCompleted SuccessResult { get; }

        /// <summary>
        /// <see cref="PlayStarted"/> event will be returned once the play has started successfully.
        /// </summary>
        public PlayStarted StartResult { get; }

        /// <summary>
        /// <see cref="PlayPaused"/> event will be returned once the play is paused successfully.
        /// </summary>
        internal PlayPaused PauseResult { get; }

        /// <summary>
        /// <see cref="PlayResumed"/> event will be returned once the play is resumed successfully.
        /// </summary>
        internal PlayResumed ResumeResult { get; }

        /// <summary>
        /// <see cref="PlayFailed"/> event will be returned once the play failed.
        /// </summary>
        public PlayFailed FailureResult { get; }

        internal PlayEventResult(bool isSuccess, PlayCompleted successResult, PlayFailed failureResult, PlayStarted startResult, PlayPaused pauseResult, PlayResumed resumeResult)
        {
            IsSuccess = isSuccess;
            SuccessResult = successResult;
            FailureResult = failureResult;
            StartResult = startResult;
            PauseResult = pauseResult;
            ResumeResult = resumeResult;
        }
    }
}
