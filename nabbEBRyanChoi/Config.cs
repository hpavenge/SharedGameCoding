﻿using EloBuddy.SDK.Menu;
using EloBuddy.SDK.Menu.Values;

namespace nabbEBRyanChoi
{
    public static class Config
    {
        private const string MenuName = "NabRengar";
        private static readonly Menu Menu;

        static Config()
        {
            // Initialize the menu
            Menu = MainMenu.AddMenu(MenuName, MenuName + "_Avenge");
            // Initialize sub menus
            Modes.Initialize();
            Misc.Initialize();
            Drawing.Initialize();
        }

        public static void Initialize()
        {
        }

        public static class Modes
        {
            public const string MenuName = "Modes";
            private static readonly Menu Menu;

            static Modes()
            {
                // Initialize menu
                Menu = Config.Menu.AddSubMenu(MenuName);

                // Initialize sub groups
                Combo.Initialize();
                Menu.AddSeparator();
                Harass.Initialize();
                Menu.AddSeparator();
                LaneClear.Initialize();
                Menu.AddSeparator();
                JungleClear.Initialize();
                Menu.AddSeparator();
                Flee.Initialize();
            }

            public static void Initialize()
            {
            }

            public static class Combo
            {
                public const string GroupName = "Combo";

                private static readonly CheckBox _useQ;
                private static readonly CheckBox _useW;
                private static readonly CheckBox _useE;

                public static bool UseQ
                {
                    get { return _useQ.CurrentValue; }
                }
                public static bool UseW
                {
                    get { return _useW.CurrentValue; }
                }
                public static bool UseE
                {
                    get { return _useE.CurrentValue; }
                }

                static Combo()
                {
                    // Initialize group
                    Menu.AddGroupLabel(GroupName);

                    _useQ = Menu.Add("comboUseQ", new CheckBox("Use Q"));
                    _useW = Menu.Add("comboUseW", new CheckBox("Use W"));
                    _useE = Menu.Add("comboUseE", new CheckBox("Use E"));

                    Menu.AddLabel("Advanced features:");
                }

                public static void Initialize()
                {
                }
            }
            public static class Harass
            {
                public const string GroupName = "Harass";

                private static readonly CheckBox _useQ;
                private static readonly CheckBox _useW;
                private static readonly CheckBox _useE;

                public static bool UseQ
                {
                    get { return _useQ.CurrentValue; }
                }
                public static bool UseW
                {
                    get { return _useW.CurrentValue; }
                }
                public static bool UseE
                {
                    get { return _useE.CurrentValue; }
                }

                static Harass()
                {
                    // Initialize group
                    Menu.AddGroupLabel(GroupName);

                    _useQ = Menu.Add("harassUseQ", new CheckBox("Use Q"));
                    _useW = Menu.Add("harassUseW", new CheckBox("Use W"));
                    _useE = Menu.Add("harassUseE", new CheckBox("Use E"));
                }

                public static void Initialize()
                {
                }
            }
            public static class LaneClear
            {
                public const string GroupName = "LaneClear";

                private static readonly CheckBox _useQ;
                private static readonly CheckBox _useW;

                public static bool UseQ
                {
                    get { return _useQ.CurrentValue; }
                }
                public static bool UseW
                {
                    get { return _useW.CurrentValue; }
                }

                static LaneClear()
                {
                    // Initialize group
                    Menu.AddGroupLabel(GroupName);

                    _useQ = Menu.Add("laneUseQ", new CheckBox("Use Q"));
                    _useW = Menu.Add("laneUseW", new CheckBox("Use W"));
                }

                public static void Initialize()
                {
                }
            }
            public static class JungleClear
            {
                public const string GroupName = "JungleClear";

                private static readonly CheckBox _useQ;
                private static readonly CheckBox _useW;
                private static readonly CheckBox _useE;

                public static bool UseQ
                {
                    get { return _useQ.CurrentValue; }
                }
                public static bool UseW
                {
                    get { return _useW.CurrentValue; }
                }
                public static bool UseE
                {
                    get { return _useE.CurrentValue; }
                }

                static JungleClear()
                {
                    // Initialize group
                    Menu.AddGroupLabel(GroupName);

                    _useQ = Menu.Add("jungleUseQ", new CheckBox("Use Q"));
                    _useW = Menu.Add("jungleUseW", new CheckBox("Use W"));
                    _useE = Menu.Add("jungleUseE", new CheckBox("Use E"));
                }

                public static void Initialize()
                {
                }
            }
            public static class Flee
            {
                static Flee()
                {
                }

                public static void Initialize()
                {
                }
            }
        }
        public static class Misc
        {
            public const string MenuName = "Miscellaneous";
            private static readonly Menu Menu;

            private static readonly CheckBox _gapcloser;
            private static readonly CheckBox _interrupter;
            private static readonly CheckBox _alerter;

            public static bool GapcloserE
            {
                get { return _gapcloser.CurrentValue; }
            }
            public static bool InterruptE
            {
                get { return _interrupter.CurrentValue; }
            }
            public static bool Alerter
            {
                get { return _alerter.CurrentValue; }
            }

            static Misc()
            {
                // Initialize menu
                Menu = Config.Menu.AddSubMenu(MenuName);

                _gapcloser = Menu.Add("miscGapcloseE", new CheckBox("Use E against gapclosers"));
                _interrupter = Menu.Add("miscInterruptE", new CheckBox("Use E to interrupt dangerous spells"));
                _alerter = Menu.Add("miscAlerter", new CheckBox("Altert in chat when someone is killable with R"));
            }

            public static void Initialize()
            {
            }
        }

        public static class Drawing
        {
            public const string MenuName = "Drawing";
            private static readonly Menu Menu;

            private static readonly CheckBox _drawQ;
            private static readonly CheckBox _drawW;
            private static readonly CheckBox _drawE;

            private static readonly CheckBox _healthbar;
            private static readonly CheckBox _percent;

            public static bool DrawQ
            {
                get { return _drawQ.CurrentValue; }
            }
            public static bool DrawW
            {
                get { return _drawW.CurrentValue; }
            }
            public static bool DrawE
            {
                get { return _drawE.CurrentValue; }
            }
            public static bool IndicatorHealthbar
            {
                get { return _healthbar.CurrentValue; }
            }
            public static bool IndicatorPercent
            {
                get { return _percent.CurrentValue; }
            }

            static Drawing()
            {
                // Initialize menu
                Menu = Config.Menu.AddSubMenu(MenuName);

                Menu.AddGroupLabel("Spell ranges");
                _drawQ = Menu.Add("drawQ", new CheckBox("Q range"));
                _drawW = Menu.Add("drawW", new CheckBox("W range"));
                _drawE = Menu.Add("drawE", new CheckBox("E range"));
                Menu.AddGroupLabel("Damage indicators");
                _healthbar = Menu.Add("healthbar", new CheckBox("Healthbar overlay"));
                _percent = Menu.Add("percent", new CheckBox("Damage percent info"));
            }

            public static void Initialize()
            {
            }
        }

    }
}
