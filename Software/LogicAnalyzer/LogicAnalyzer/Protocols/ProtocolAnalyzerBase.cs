﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicAnalyzer.Protocols
{
    public abstract class ProtocolAnalyzerBase
    {
        /// <summary>
        /// Protocol name to show in the menu
        /// </summary>
        public abstract string ProtocolName { get; }
        /// <summary>
        /// List of settings needed by the analyzer
        /// </summary>
        public abstract ProtocolAnalyzerSetting[] Settings { get; }
        /// <summary>
        /// List of signals used by the protocol analyzer
        /// </summary>
        public abstract ProtocolAnalyzerSignal[] Signals { get; }
        /// <summary>
        /// Validates if settings are correct
        /// </summary>
        /// <param name="SelectedSettings">Settings to validate</param>
        /// <param name="SelectedChannels">Selected channels</param>
        /// <returns></returns>
        public abstract bool ValidateSettings(ProtocolAnalyzerSettingValue[] SelectedSettings, ProtocolAnalyzerSelectedChannel[] SelectedChannels);
        /// <summary>
        /// Analyzes a set of samples
        /// </summary>
        /// <param name="SelectedSettings">Settings to use to analyze the protocol</param>
        /// <param name="SelectedChannels">Channels to analyze</param>
        /// <returns>An array of analyzed channels</returns>
        public abstract ProtocolAnalyzedChannel[] Analyze(int SamplingRate, int TriggerSample, ProtocolAnalyzerSettingValue[] SelectedSettings, ProtocolAnalyzerSelectedChannel[] SelectedChannels);

        
    }
}
