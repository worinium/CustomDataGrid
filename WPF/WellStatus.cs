using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace WpfApp
{
    public class WellStatus
    {
        #region Private Properties

        int wellID;
        string wellName;
        string wellAccessories;
        string malfunction;
        string cause;
        string riskLevel;
        string waiverStartDate;
        string waiverEndDate;
        string waiverDuration;
        string waiverStatus;
        string action;
        string actionParty;

        #endregion Private Properties

        public int WellID
        {
            get { return wellID; }
            set { wellID = value; }
        }

        public string WellName
        {
            get { return wellName; }
            set { wellName = value; }
        }

        public string WellAccessories
        {
            get { return wellAccessories; }
            set { wellAccessories = value; }
        }

        public string Malfunction
        {
            get { return malfunction; }
            set { malfunction = value; }
        } 

        public string Cause
        {
            get { return cause; }
            set { cause = value; }
        }

        public string RiskLevel
        {
            get { return riskLevel; }
            set { riskLevel = value; }
        }
        
        public string WaiverStartDate
        {
            get { return waiverStartDate; }
            set { waiverStartDate = value; }
        } 
        public string WaiverEndDate
        {
            get { return waiverEndDate; }
            set { waiverEndDate = value; }
        } 
        public string WaiverDuration
        {
            get { return waiverDuration; }
            set { waiverDuration = value; }
        }
        public string WaiverStatus
        {
            get { return waiverStatus; }
            set { waiverStatus = value; }
        }
        public string Action
        {
            get { return action; }
            set { action = value; }
        }
        public string ActionParty
        {
            get { return actionParty; }
            set { actionParty = value; }
        }
        /// <summary>
        /// Constructing Well Status Report
        /// </summary>
        /// <param name="wellId"></param>
        /// <param name="wellName"></param>
        /// <param name="wellAccessories"></param>
        /// <param name="malfunction"></param>
        /// <param name="cause"></param>
        /// <param name="riskLevel"></param>
        /// <param name="waiverStartDate"></param>
        /// <param name="waiverEndDate"></param>
        /// <param name="waiverDuration"></param>
        /// <param name="waiverStatus"></param>
        /// <param name="action"></param>
        /// <param name="actionParty"></param>
        public WellStatus(int wellId, string wellName, string wellAccessories, string malfunction, string cause, string riskLevel, string waiverStartDate, string waiverEndDate, string waiverDuration, string waiverStatus, string action, string actionParty)
        {
            this.wellID = wellId;
            this.wellName = wellName;
            this.wellAccessories = wellAccessories;
            this.malfunction = malfunction;
            this.cause = cause;
            this.riskLevel = riskLevel;
            this.waiverStartDate = waiverStartDate;
            this.waiverEndDate = waiverEndDate;
            this.WaiverDuration = waiverDuration;
            this.waiverStatus = waiverStatus;
            this.action = action;
            this.actionParty = actionParty;
        }
    }
}