using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using TransitionsLibrary.Models;
using static TransitionsLibrary.Models.Functions.Easings;
using static TransitionsLibrary.Models.ValueTransition;

namespace NotificationsTest
{
    public partial class MainForm : Form
    {
        private TransitionManager ShowTransition; // Transition Manager to show hidden (out of bounds) cards
        private TransitionManager HideTransition; // Trnasition Manager to hide shown cards
        private List<Guna2Panel> TargetCards;
        private bool CardsAreShown = false; // Cards view state
        public MainForm()
        {
            InitializeComponent();
            InitializeTransitions();
        }

        private void InitializeTransitions()
        {
            Random random = new Random();
            ShowTransition = new TransitionManager();
            HideTransition = new TransitionManager();
            TargetCards = new List<Guna2Panel>() { Card1, Card2, Card3 }; // Cards list
            int hiddenOffsetX = 100; // offset in px used to push element away from borders
            int defaultCardX = 19; // default X location of cards when they are shown

            // ShowTransitions
            {
                for (int i = 0; i < TargetCards.Count; i++)
                {
                    // Setting card X location
                    // x < 0 - card will flow from left side, transition direction =>
                    // x > 0 - card will flow from right side, transition direction <=
                    int x = i % 2 == 0 ? -hiddenOffsetX - TargetCards[i].Width : this.Width + hiddenOffsetX + TargetCards[i].Width;
                    var showTransition = new ValueTransition
                    (
                        startValue: x, // Left side / right side start X location
                        endValue: defaultCardX, // default X location of cards when they are shown
                        duration: 1400, // transition time in ms
                        onValueChanged: OnValueChanged, // CallBack method (float value, Control control)
                        easingFunction: Elastic.InOut, // Transition function from TransitionsLibrary.Models.Functions.Easings
                        targetControl: TargetCards[i], // Target, used to simply work with callback parameter Control control
                        fps: 60, // Frames Per Second
                        startDelay: i * 500 // delay for transition
                    );

                    ShowTransition.Transitions.Add(showTransition);
                }
            }

            // Adding callback method to change CardsAreShown value on true
            ShowTransition.OnTransitionsEnds = new Action(delegate { CardsAreShown = true; }); 

            // HideTransitions
            { 
                for (int i = 0; i < TargetCards.Count; i++)
                {
                    // Setting card X location
                    // x < 0 - card will flow from left side, transition direction =>
                    // x > 0 - card will flow from right side, transition direction <=
                    int x = i % 2 == 0 ? -hiddenOffsetX - TargetCards[i].Width : this.Width + hiddenOffsetX + TargetCards[i].Width;
                    var hideTransition = new ValueTransition
                    (
                        startValue: defaultCardX, // default X location of cards when they are shown
                        endValue: x, // target x location
                        duration: 800, // transition time in ms
                        onValueChanged: OnValueChanged, // CallBack method (float value, Control control)
                        easingFunction: Elastic.InOut,  // Transition function from TransitionsLibrary.Models.Functions.Easings
                        targetControl: TargetCards[i], // Target, used to simply work with callback parameter Control control
                        fps: 60, // Frames Per Second
                        startDelay: i * 200 // delay for transition
                    );

                    HideTransition.Transitions.Add(hideTransition);
                }
            }

            // Adding callback method to change CardsAreShown value on false
            HideTransition.OnTransitionsEnds = new Action(delegate { CardsAreShown = false; });

            // Settings start location for all card panels
            {
                for (int i = 0; i < TargetCards.Count; i++)
                {
                    // Left side / Right side set
                    int x = i % 2 == 0 ? -hiddenOffsetX - TargetCards[i].Width: this.Width + hiddenOffsetX + TargetCards[i].Width;
                    TargetCards[i].Location = new Point(x, TargetCards[i].Location.Y);
                }
            }
        }

        private void OnValueChanged(float value, Control control)
        {
            if (InvokeRequired)
            {
                Invoke(new OnValueChangedDelegate(OnValueChanged), new object[] { value, control });
            }
            else
            {
                // control.Location = new Point((int)value, control.Location.Y);
                control.Left = (int)value;
            }
        }

        public void ShowCards()
        {
            if (!CardsAreShown) 
                ShowTransition.Start();
        }
        public void HideCards()
        {
            if (CardsAreShown) 
                HideTransition.Start();
        }

        private void ShowButton_Click(object sender, EventArgs e)
        {
            ShowCards();
        }

        private void HideButton_Click(object sender, EventArgs e)
        {
            HideCards();
        }

        private void ShowNotificationButton_Click(object sender, EventArgs e)
        {
            NotificationForm notification = new NotificationForm();
            notification.Show();
        }
    }
}
