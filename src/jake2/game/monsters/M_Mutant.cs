using Q2Sharp.Client;
using Q2Sharp.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Q2Sharp.Game.Monsters
{
    public class M_Mutant
    {
        public static readonly int FRAME_attack01 = 0;
        public static readonly int FRAME_attack02 = 1;
        public static readonly int FRAME_attack03 = 2;
        public static readonly int FRAME_attack04 = 3;
        public static readonly int FRAME_attack05 = 4;
        public static readonly int FRAME_attack06 = 5;
        public static readonly int FRAME_attack07 = 6;
        public static readonly int FRAME_attack08 = 7;
        public static readonly int FRAME_attack09 = 8;
        public static readonly int FRAME_attack10 = 9;
        public static readonly int FRAME_attack11 = 10;
        public static readonly int FRAME_attack12 = 11;
        public static readonly int FRAME_attack13 = 12;
        public static readonly int FRAME_attack14 = 13;
        public static readonly int FRAME_attack15 = 14;
        public static readonly int FRAME_death101 = 15;
        public static readonly int FRAME_death102 = 16;
        public static readonly int FRAME_death103 = 17;
        public static readonly int FRAME_death104 = 18;
        public static readonly int FRAME_death105 = 19;
        public static readonly int FRAME_death106 = 20;
        public static readonly int FRAME_death107 = 21;
        public static readonly int FRAME_death108 = 22;
        public static readonly int FRAME_death109 = 23;
        public static readonly int FRAME_death201 = 24;
        public static readonly int FRAME_death202 = 25;
        public static readonly int FRAME_death203 = 26;
        public static readonly int FRAME_death204 = 27;
        public static readonly int FRAME_death205 = 28;
        public static readonly int FRAME_death206 = 29;
        public static readonly int FRAME_death207 = 30;
        public static readonly int FRAME_death208 = 31;
        public static readonly int FRAME_death209 = 32;
        public static readonly int FRAME_death210 = 33;
        public static readonly int FRAME_pain101 = 34;
        public static readonly int FRAME_pain102 = 35;
        public static readonly int FRAME_pain103 = 36;
        public static readonly int FRAME_pain104 = 37;
        public static readonly int FRAME_pain105 = 38;
        public static readonly int FRAME_pain201 = 39;
        public static readonly int FRAME_pain202 = 40;
        public static readonly int FRAME_pain203 = 41;
        public static readonly int FRAME_pain204 = 42;
        public static readonly int FRAME_pain205 = 43;
        public static readonly int FRAME_pain206 = 44;
        public static readonly int FRAME_pain301 = 45;
        public static readonly int FRAME_pain302 = 46;
        public static readonly int FRAME_pain303 = 47;
        public static readonly int FRAME_pain304 = 48;
        public static readonly int FRAME_pain305 = 49;
        public static readonly int FRAME_pain306 = 50;
        public static readonly int FRAME_pain307 = 51;
        public static readonly int FRAME_pain308 = 52;
        public static readonly int FRAME_pain309 = 53;
        public static readonly int FRAME_pain310 = 54;
        public static readonly int FRAME_pain311 = 55;
        public static readonly int FRAME_run03 = 56;
        public static readonly int FRAME_run04 = 57;
        public static readonly int FRAME_run05 = 58;
        public static readonly int FRAME_run06 = 59;
        public static readonly int FRAME_run07 = 60;
        public static readonly int FRAME_run08 = 61;
        public static readonly int FRAME_stand101 = 62;
        public static readonly int FRAME_stand102 = 63;
        public static readonly int FRAME_stand103 = 64;
        public static readonly int FRAME_stand104 = 65;
        public static readonly int FRAME_stand105 = 66;
        public static readonly int FRAME_stand106 = 67;
        public static readonly int FRAME_stand107 = 68;
        public static readonly int FRAME_stand108 = 69;
        public static readonly int FRAME_stand109 = 70;
        public static readonly int FRAME_stand110 = 71;
        public static readonly int FRAME_stand111 = 72;
        public static readonly int FRAME_stand112 = 73;
        public static readonly int FRAME_stand113 = 74;
        public static readonly int FRAME_stand114 = 75;
        public static readonly int FRAME_stand115 = 76;
        public static readonly int FRAME_stand116 = 77;
        public static readonly int FRAME_stand117 = 78;
        public static readonly int FRAME_stand118 = 79;
        public static readonly int FRAME_stand119 = 80;
        public static readonly int FRAME_stand120 = 81;
        public static readonly int FRAME_stand121 = 82;
        public static readonly int FRAME_stand122 = 83;
        public static readonly int FRAME_stand123 = 84;
        public static readonly int FRAME_stand124 = 85;
        public static readonly int FRAME_stand125 = 86;
        public static readonly int FRAME_stand126 = 87;
        public static readonly int FRAME_stand127 = 88;
        public static readonly int FRAME_stand128 = 89;
        public static readonly int FRAME_stand129 = 90;
        public static readonly int FRAME_stand130 = 91;
        public static readonly int FRAME_stand131 = 92;
        public static readonly int FRAME_stand132 = 93;
        public static readonly int FRAME_stand133 = 94;
        public static readonly int FRAME_stand134 = 95;
        public static readonly int FRAME_stand135 = 96;
        public static readonly int FRAME_stand136 = 97;
        public static readonly int FRAME_stand137 = 98;
        public static readonly int FRAME_stand138 = 99;
        public static readonly int FRAME_stand139 = 100;
        public static readonly int FRAME_stand140 = 101;
        public static readonly int FRAME_stand141 = 102;
        public static readonly int FRAME_stand142 = 103;
        public static readonly int FRAME_stand143 = 104;
        public static readonly int FRAME_stand144 = 105;
        public static readonly int FRAME_stand145 = 106;
        public static readonly int FRAME_stand146 = 107;
        public static readonly int FRAME_stand147 = 108;
        public static readonly int FRAME_stand148 = 109;
        public static readonly int FRAME_stand149 = 110;
        public static readonly int FRAME_stand150 = 111;
        public static readonly int FRAME_stand151 = 112;
        public static readonly int FRAME_stand152 = 113;
        public static readonly int FRAME_stand153 = 114;
        public static readonly int FRAME_stand154 = 115;
        public static readonly int FRAME_stand155 = 116;
        public static readonly int FRAME_stand156 = 117;
        public static readonly int FRAME_stand157 = 118;
        public static readonly int FRAME_stand158 = 119;
        public static readonly int FRAME_stand159 = 120;
        public static readonly int FRAME_stand160 = 121;
        public static readonly int FRAME_stand161 = 122;
        public static readonly int FRAME_stand162 = 123;
        public static readonly int FRAME_stand163 = 124;
        public static readonly int FRAME_stand164 = 125;
        public static readonly int FRAME_walk01 = 126;
        public static readonly int FRAME_walk02 = 127;
        public static readonly int FRAME_walk03 = 128;
        public static readonly int FRAME_walk04 = 129;
        public static readonly int FRAME_walk05 = 130;
        public static readonly int FRAME_walk06 = 131;
        public static readonly int FRAME_walk07 = 132;
        public static readonly int FRAME_walk08 = 133;
        public static readonly int FRAME_walk09 = 134;
        public static readonly int FRAME_walk10 = 135;
        public static readonly int FRAME_walk11 = 136;
        public static readonly int FRAME_walk12 = 137;
        public static readonly int FRAME_walk13 = 138;
        public static readonly int FRAME_walk14 = 139;
        public static readonly int FRAME_walk15 = 140;
        public static readonly int FRAME_walk16 = 141;
        public static readonly int FRAME_walk17 = 142;
        public static readonly int FRAME_walk18 = 143;
        public static readonly int FRAME_walk19 = 144;
        public static readonly int FRAME_walk20 = 145;
        public static readonly int FRAME_walk21 = 146;
        public static readonly int FRAME_walk22 = 147;
        public static readonly int FRAME_walk23 = 148;
        public static readonly float MODEL_SCALE = 1F;
        static int sound_swing;
        static int sound_hit;
        static int sound_hit2;
        static int sound_death;
        static int sound_idle;
        static int sound_pain1;
        static int sound_pain2;
        static int sound_sight;
        static int sound_search;
        static int sound_step1;
        static int sound_step2;
        static int sound_step3;
        static int sound_thud;
        static EntThinkAdapter mutant_step = new AnonymousEntThinkAdapter();
        private sealed class AnonymousEntThinkAdapter : EntThinkAdapter
		{
			
            public override string GetID()
            {
                return "mutant_step";
            }

            public override bool Think(edict_t self)
            {
                int n;
                n = (Lib.Rand() + 1) % 3;
                if (n == 0)
                    GameBase.gi.Sound(self, Defines.CHAN_VOICE, sound_step1, 1, Defines.ATTN_NORM, 0);
                else if (n == 1)
                    GameBase.gi.Sound(self, Defines.CHAN_VOICE, sound_step2, 1, Defines.ATTN_NORM, 0);
                else
                    GameBase.gi.Sound(self, Defines.CHAN_VOICE, sound_step3, 1, Defines.ATTN_NORM, 0);
                return true;
            }
        }

        static EntInteractAdapter mutant_sight = new AnonymousEntInteractAdapter();
        private sealed class AnonymousEntInteractAdapter : EntInteractAdapter
		{
			
            public override string GetID()
            {
                return "mutant_sight";
            }

            public override bool Interact(edict_t self, edict_t other)
            {
                GameBase.gi.Sound(self, Defines.CHAN_VOICE, sound_sight, 1, Defines.ATTN_NORM, 0);
                return true;
            }
        }

        static EntThinkAdapter mutant_search = new AnonymousEntThinkAdapter1();
        private sealed class AnonymousEntThinkAdapter1 : EntThinkAdapter
		{
			
            public override string GetID()
            {
                return "mutant_search";
            }

            public override bool Think(edict_t self)
            {
                GameBase.gi.Sound(self, Defines.CHAN_VOICE, sound_search, 1, Defines.ATTN_NORM, 0);
                return true;
            }
        }

        static EntThinkAdapter mutant_swing = new AnonymousEntThinkAdapter2();
        private sealed class AnonymousEntThinkAdapter2 : EntThinkAdapter
		{
			
            public override string GetID()
            {
                return "mutant_swing";
            }

            public override bool Think(edict_t self)
            {
                GameBase.gi.Sound(self, Defines.CHAN_VOICE, sound_swing, 1, Defines.ATTN_NORM, 0);
                return true;
            }
        }

        static mframe_t[] mutant_frames_stand = new mframe_t[]{new mframe_t(GameAI.ai_stand, 0, null), new mframe_t(GameAI.ai_stand, 0, null), new mframe_t(GameAI.ai_stand, 0, null), new mframe_t(GameAI.ai_stand, 0, null), new mframe_t(GameAI.ai_stand, 0, null), new mframe_t(GameAI.ai_stand, 0, null), new mframe_t(GameAI.ai_stand, 0, null), new mframe_t(GameAI.ai_stand, 0, null), new mframe_t(GameAI.ai_stand, 0, null), new mframe_t(GameAI.ai_stand, 0, null), new mframe_t(GameAI.ai_stand, 0, null), new mframe_t(GameAI.ai_stand, 0, null), new mframe_t(GameAI.ai_stand, 0, null), new mframe_t(GameAI.ai_stand, 0, null), new mframe_t(GameAI.ai_stand, 0, null), new mframe_t(GameAI.ai_stand, 0, null), new mframe_t(GameAI.ai_stand, 0, null), new mframe_t(GameAI.ai_stand, 0, null), new mframe_t(GameAI.ai_stand, 0, null), new mframe_t(GameAI.ai_stand, 0, null), new mframe_t(GameAI.ai_stand, 0, null), new mframe_t(GameAI.ai_stand, 0, null), new mframe_t(GameAI.ai_stand, 0, null), new mframe_t(GameAI.ai_stand, 0, null), new mframe_t(GameAI.ai_stand, 0, null), new mframe_t(GameAI.ai_stand, 0, null), new mframe_t(GameAI.ai_stand, 0, null), new mframe_t(GameAI.ai_stand, 0, null), new mframe_t(GameAI.ai_stand, 0, null), new mframe_t(GameAI.ai_stand, 0, null), new mframe_t(GameAI.ai_stand, 0, null), new mframe_t(GameAI.ai_stand, 0, null), new mframe_t(GameAI.ai_stand, 0, null), new mframe_t(GameAI.ai_stand, 0, null), new mframe_t(GameAI.ai_stand, 0, null), new mframe_t(GameAI.ai_stand, 0, null), new mframe_t(GameAI.ai_stand, 0, null), new mframe_t(GameAI.ai_stand, 0, null), new mframe_t(GameAI.ai_stand, 0, null), new mframe_t(GameAI.ai_stand, 0, null), new mframe_t(GameAI.ai_stand, 0, null), new mframe_t(GameAI.ai_stand, 0, null), new mframe_t(GameAI.ai_stand, 0, null), new mframe_t(GameAI.ai_stand, 0, null), new mframe_t(GameAI.ai_stand, 0, null), new mframe_t(GameAI.ai_stand, 0, null), new mframe_t(GameAI.ai_stand, 0, null), new mframe_t(GameAI.ai_stand, 0, null), new mframe_t(GameAI.ai_stand, 0, null), new mframe_t(GameAI.ai_stand, 0, null), new mframe_t(GameAI.ai_stand, 0, null)};
        static mmove_t mutant_move_stand = new mmove_t(FRAME_stand101, FRAME_stand151, mutant_frames_stand, null);
        static EntThinkAdapter mutant_stand = new AnonymousEntThinkAdapter3();
        private sealed class AnonymousEntThinkAdapter3 : EntThinkAdapter
		{
			
            public override string GetID()
            {
                return "mutant_stand";
            }

            public override bool Think(edict_t self)
            {
                self.monsterinfo.currentmove = mutant_move_stand;
                return true;
            }
        }

        static EntThinkAdapter mutant_idle_loop = new AnonymousEntThinkAdapter4();
        private sealed class AnonymousEntThinkAdapter4 : EntThinkAdapter
		{
			
            public override string GetID()
            {
                return "mutant_idle_loop";
            }

            public override bool Think(edict_t self)
            {
                if (Lib.Random() < 0.75)
                    self.monsterinfo.nextframe = FRAME_stand155;
                return true;
            }
        }

        static mframe_t[] mutant_frames_idle = new mframe_t[]{new mframe_t(GameAI.ai_stand, 0, null), new mframe_t(GameAI.ai_stand, 0, null), new mframe_t(GameAI.ai_stand, 0, null), new mframe_t(GameAI.ai_stand, 0, null), new mframe_t(GameAI.ai_stand, 0, null), new mframe_t(GameAI.ai_stand, 0, null), new mframe_t(GameAI.ai_stand, 0, mutant_idle_loop), new mframe_t(GameAI.ai_stand, 0, null), new mframe_t(GameAI.ai_stand, 0, null), new mframe_t(GameAI.ai_stand, 0, null), new mframe_t(GameAI.ai_stand, 0, null), new mframe_t(GameAI.ai_stand, 0, null), new mframe_t(GameAI.ai_stand, 0, null)};
        static mmove_t mutant_move_idle = new mmove_t(FRAME_stand152, FRAME_stand164, mutant_frames_idle, mutant_stand);
        static EntThinkAdapter mutant_idle = new AnonymousEntThinkAdapter5();
        private sealed class AnonymousEntThinkAdapter5 : EntThinkAdapter
		{
			
            public override string GetID()
            {
                return "mutant_idle";
            }

            public override bool Think(edict_t self)
            {
                self.monsterinfo.currentmove = mutant_move_idle;
                GameBase.gi.Sound(self, Defines.CHAN_VOICE, sound_idle, 1, Defines.ATTN_IDLE, 0);
                return true;
            }
        }

        static mframe_t[] mutant_frames_walk = new mframe_t[]{new mframe_t(GameAI.ai_walk, 3, null), new mframe_t(GameAI.ai_walk, 1, null), new mframe_t(GameAI.ai_walk, 5, null), new mframe_t(GameAI.ai_walk, 10, null), new mframe_t(GameAI.ai_walk, 13, null), new mframe_t(GameAI.ai_walk, 10, null), new mframe_t(GameAI.ai_walk, 0, null), new mframe_t(GameAI.ai_walk, 5, null), new mframe_t(GameAI.ai_walk, 6, null), new mframe_t(GameAI.ai_walk, 16, null), new mframe_t(GameAI.ai_walk, 15, null), new mframe_t(GameAI.ai_walk, 6, null)};
        static mmove_t mutant_move_walk = new mmove_t(FRAME_walk05, FRAME_walk16, mutant_frames_walk, null);
        static EntThinkAdapter mutant_walk_loop = new AnonymousEntThinkAdapter6();
        private sealed class AnonymousEntThinkAdapter6 : EntThinkAdapter
		{
			
            public override string GetID()
            {
                return "mutant_walk_loop";
            }

            public override bool Think(edict_t self)
            {
                self.monsterinfo.currentmove = mutant_move_walk;
                return true;
            }
        }

        static mframe_t[] mutant_frames_start_walk = new mframe_t[]{new mframe_t(GameAI.ai_walk, 5, null), new mframe_t(GameAI.ai_walk, 5, null), new mframe_t(GameAI.ai_walk, -2, null), new mframe_t(GameAI.ai_walk, 1, null)};
        static mmove_t mutant_move_start_walk = new mmove_t(FRAME_walk01, FRAME_walk04, mutant_frames_start_walk, mutant_walk_loop);
        static EntThinkAdapter mutant_walk = new AnonymousEntThinkAdapter7();
        private sealed class AnonymousEntThinkAdapter7 : EntThinkAdapter
		{
			
            public override string GetID()
            {
                return "mutant_walk";
            }

            public override bool Think(edict_t self)
            {
                self.monsterinfo.currentmove = mutant_move_start_walk;
                return true;
            }
        }

        static mframe_t[] mutant_frames_run = new mframe_t[]{new mframe_t(GameAI.ai_run, 40, null), new mframe_t(GameAI.ai_run, 40, mutant_step), new mframe_t(GameAI.ai_run, 24, null), new mframe_t(GameAI.ai_run, 5, mutant_step), new mframe_t(GameAI.ai_run, 17, null), new mframe_t(GameAI.ai_run, 10, null)};
        static mmove_t mutant_move_run = new mmove_t(FRAME_run03, FRAME_run08, mutant_frames_run, null);
        static EntThinkAdapter mutant_run = new AnonymousEntThinkAdapter8();
        private sealed class AnonymousEntThinkAdapter8 : EntThinkAdapter
		{
			
            public override string GetID()
            {
                return "mutant_run";
            }

            public override bool Think(edict_t self)
            {
                if ((self.monsterinfo.aiflags & Defines.AI_STAND_GROUND) != 0)
                    self.monsterinfo.currentmove = mutant_move_stand;
                else
                    self.monsterinfo.currentmove = mutant_move_run;
                return true;
            }
        }

        static EntThinkAdapter mutant_hit_left = new AnonymousEntThinkAdapter9();
        private sealed class AnonymousEntThinkAdapter9 : EntThinkAdapter
		{
			
            public override string GetID()
            {
                return "mutant_hit_left";
            }

            public override bool Think(edict_t self)
            {
                float[] aim = new float[]{0, 0, 0};
                Math3D.VectorSet(aim, Defines.MELEE_DISTANCE, self.mins[0], 8);
                if (GameWeapon.Fire_hit(self, aim, (10 + (Lib.Rand() % 5)), 100))
                    GameBase.gi.Sound(self, Defines.CHAN_WEAPON, sound_hit, 1, Defines.ATTN_NORM, 0);
                else
                    GameBase.gi.Sound(self, Defines.CHAN_WEAPON, sound_swing, 1, Defines.ATTN_NORM, 0);
                return true;
            }
        }

        static EntThinkAdapter mutant_hit_right = new AnonymousEntThinkAdapter10();
        private sealed class AnonymousEntThinkAdapter10 : EntThinkAdapter
		{
			
            public override string GetID()
            {
                return "mutant_hit_right";
            }

            public override bool Think(edict_t self)
            {
                float[] aim = new float[]{0, 0, 0};
                Math3D.VectorSet(aim, Defines.MELEE_DISTANCE, self.maxs[0], 8);
                if (GameWeapon.Fire_hit(self, aim, (10 + (Lib.Rand() % 5)), 100))
                    GameBase.gi.Sound(self, Defines.CHAN_WEAPON, sound_hit2, 1, Defines.ATTN_NORM, 0);
                else
                    GameBase.gi.Sound(self, Defines.CHAN_WEAPON, sound_swing, 1, Defines.ATTN_NORM, 0);
                return true;
            }
        }

        static EntThinkAdapter mutant_check_refire = new AnonymousEntThinkAdapter11();
        private sealed class AnonymousEntThinkAdapter11 : EntThinkAdapter
		{
			
            public override string GetID()
            {
                return "mutant_check_refire";
            }

            public override bool Think(edict_t self)
            {
                if (null == self.enemy || !self.enemy.inuse || self.enemy.health <= 0)
                    return true;
                if (((GameBase.skill.value == 3) && (Lib.Random() < 0.5)) || (GameUtil.Range(self, self.enemy) == Defines.RANGE_MELEE))
                    self.monsterinfo.nextframe = FRAME_attack09;
                return true;
            }
        }

        static mframe_t[] mutant_frames_attack = new mframe_t[]{new mframe_t(GameAI.ai_charge, 0, null), new mframe_t(GameAI.ai_charge, 0, null), new mframe_t(GameAI.ai_charge, 0, mutant_hit_left), new mframe_t(GameAI.ai_charge, 0, null), new mframe_t(GameAI.ai_charge, 0, null), new mframe_t(GameAI.ai_charge, 0, mutant_hit_right), new mframe_t(GameAI.ai_charge, 0, mutant_check_refire)};
        static mmove_t mutant_move_attack = new mmove_t(FRAME_attack09, FRAME_attack15, mutant_frames_attack, mutant_run);
        static EntThinkAdapter mutant_melee = new AnonymousEntThinkAdapter12();
        private sealed class AnonymousEntThinkAdapter12 : EntThinkAdapter
		{
			
            public override string GetID()
            {
                return "mutant_melee";
            }

            public override bool Think(edict_t self)
            {
                self.monsterinfo.currentmove = mutant_move_attack;
                return true;
            }
        }

        static EntTouchAdapter mutant_jump_touch = new AnonymousEntTouchAdapter();
        private sealed class AnonymousEntTouchAdapter : EntTouchAdapter
		{
			
            public override string GetID()
            {
                return "mutant_jump_touch";
            }

            public override void Touch(edict_t self, edict_t other, cplane_t plane, csurface_t surf)
            {
                if (self.health <= 0)
                {
                    self.touch = null;
                    return;
                }

                if (other.takedamage != 0)
                {
                    if (Math3D.VectorLength(self.velocity) > 400)
                    {
                        float[] point = new float[]{0, 0, 0};
                        float[] normal = new float[]{0, 0, 0};
                        int damage;
                        Math3D.VectorCopy(self.velocity, normal);
                        Math3D.VectorNormalize(normal);
                        Math3D.VectorMA(self.s.origin, self.maxs[0], normal, point);
                        damage = (int)(40 + 10 * Lib.Random());
                        GameCombat.T_Damage(other, self, self, self.velocity, point, normal, damage, damage, 0, Defines.MOD_UNKNOWN);
                    }
                }

                if (!M.M_CheckBottom(self))
                {
                    if (self.groundentity != null)
                    {
                        self.monsterinfo.nextframe = FRAME_attack02;
                        self.touch = null;
                    }

                    return;
                }

                self.touch = null;
            }
        }

        static EntThinkAdapter mutant_jump_takeoff = new AnonymousEntThinkAdapter13();
        private sealed class AnonymousEntThinkAdapter13 : EntThinkAdapter
		{
			
            public override string GetID()
            {
                return "mutant_jump_takeoff";
            }

            public override bool Think(edict_t self)
            {
                float[] forward = new float[]{0, 0, 0};
                GameBase.gi.Sound(self, Defines.CHAN_VOICE, sound_sight, 1, Defines.ATTN_NORM, 0);
                Math3D.AngleVectors(self.s.angles, forward, null, null);
                self.s.origin[2] += 1;
                Math3D.VectorScale(forward, 600, self.velocity);
                self.velocity[2] = 250;
                self.groundentity = null;
                self.monsterinfo.aiflags |= Defines.AI_DUCKED;
                self.monsterinfo.attack_finished = GameBase.level.time + 3;
                self.touch = mutant_jump_touch;
                return true;
            }
        }

        static EntThinkAdapter mutant_check_landing = new AnonymousEntThinkAdapter14();
        private sealed class AnonymousEntThinkAdapter14 : EntThinkAdapter
		{
			
            public override string GetID()
            {
                return "mutant_check_landing";
            }

            public override bool Think(edict_t self)
            {
                if (self.groundentity != null)
                {
                    GameBase.gi.Sound(self, Defines.CHAN_WEAPON, sound_thud, 1, Defines.ATTN_NORM, 0);
                    self.monsterinfo.attack_finished = 0;
                    self.monsterinfo.aiflags &= ~Defines.AI_DUCKED;
                    return true;
                }

                if (GameBase.level.time > self.monsterinfo.attack_finished)
                    self.monsterinfo.nextframe = FRAME_attack02;
                else
                    self.monsterinfo.nextframe = FRAME_attack05;
                return true;
            }
        }

        static mframe_t[] mutant_frames_jump = new mframe_t[]{new mframe_t(GameAI.ai_charge, 0, null), new mframe_t(GameAI.ai_charge, 17, null), new mframe_t(GameAI.ai_charge, 15, mutant_jump_takeoff), new mframe_t(GameAI.ai_charge, 15, null), new mframe_t(GameAI.ai_charge, 15, mutant_check_landing), new mframe_t(GameAI.ai_charge, 0, null), new mframe_t(GameAI.ai_charge, 3, null), new mframe_t(GameAI.ai_charge, 0, null)};
        static mmove_t mutant_move_jump = new mmove_t(FRAME_attack01, FRAME_attack08, mutant_frames_jump, mutant_run);
        static EntThinkAdapter mutant_jump = new AnonymousEntThinkAdapter15();
        private sealed class AnonymousEntThinkAdapter15 : EntThinkAdapter
		{
			
            public override string GetID()
            {
                return "mutant_jump";
            }

            public override bool Think(edict_t self)
            {
                self.monsterinfo.currentmove = mutant_move_jump;
                return true;
            }
        }

        static EntThinkAdapter mutant_check_melee = new AnonymousEntThinkAdapter16();
        private sealed class AnonymousEntThinkAdapter16 : EntThinkAdapter
		{
			
            public override string GetID()
            {
                return "mutant_check_melee";
            }

            public override bool Think(edict_t self)
            {
                if (GameUtil.Range(self, self.enemy) == Defines.RANGE_MELEE)
                    return true;
                return false;
            }
        }

        static EntThinkAdapter mutant_check_jump = new AnonymousEntThinkAdapter17();
        private sealed class AnonymousEntThinkAdapter17 : EntThinkAdapter
		{
			
            public override string GetID()
            {
                return "mutant_check_jump";
            }

            public override bool Think(edict_t self)
            {
                float[] v = new float[]{0, 0, 0};
                float distance;
                if (self.absmin[2] > (self.enemy.absmin[2] + 0.75 * self.enemy.size[2]))
                    return false;
                if (self.absmax[2] < (self.enemy.absmin[2] + 0.25 * self.enemy.size[2]))
                    return false;
                v[0] = self.s.origin[0] - self.enemy.s.origin[0];
                v[1] = self.s.origin[1] - self.enemy.s.origin[1];
                v[2] = 0;
                distance = Math3D.VectorLength(v);
                if (distance < 100)
                    return false;
                if (distance > 100)
                {
                    if (Lib.Random() < 0.9)
                        return false;
                }

                return true;
            }
        }

        static EntThinkAdapter mutant_checkattack = new AnonymousEntThinkAdapter18();
        private sealed class AnonymousEntThinkAdapter18 : EntThinkAdapter
		{
			
            public override string GetID()
            {
                return "mutant_checkattack";
            }

            public override bool Think(edict_t self)
            {
                if (null == self.enemy || self.enemy.health <= 0)
                    return false;
                if (mutant_check_melee.Think(self))
                {
                    self.monsterinfo.attack_state = Defines.AS_MELEE;
                    return true;
                }

                if (mutant_check_jump.Think(self))
                {
                    self.monsterinfo.attack_state = Defines.AS_MISSILE;
                    return true;
                }

                return false;
            }
        }

        static mframe_t[] mutant_frames_pain1 = new mframe_t[]{new mframe_t(GameAI.ai_move, 4, null), new mframe_t(GameAI.ai_move, -3, null), new mframe_t(GameAI.ai_move, -8, null), new mframe_t(GameAI.ai_move, 2, null), new mframe_t(GameAI.ai_move, 5, null)};
        static mmove_t mutant_move_pain1 = new mmove_t(FRAME_pain101, FRAME_pain105, mutant_frames_pain1, mutant_run);
        static mframe_t[] mutant_frames_pain2 = new mframe_t[]{new mframe_t(GameAI.ai_move, -24, null), new mframe_t(GameAI.ai_move, 11, null), new mframe_t(GameAI.ai_move, 5, null), new mframe_t(GameAI.ai_move, -2, null), new mframe_t(GameAI.ai_move, 6, null), new mframe_t(GameAI.ai_move, 4, null)};
        static mmove_t mutant_move_pain2 = new mmove_t(FRAME_pain201, FRAME_pain206, mutant_frames_pain2, mutant_run);
        static mframe_t[] mutant_frames_pain3 = new mframe_t[]{new mframe_t(GameAI.ai_move, -22, null), new mframe_t(GameAI.ai_move, 3, null), new mframe_t(GameAI.ai_move, 3, null), new mframe_t(GameAI.ai_move, 2, null), new mframe_t(GameAI.ai_move, 1, null), new mframe_t(GameAI.ai_move, 1, null), new mframe_t(GameAI.ai_move, 6, null), new mframe_t(GameAI.ai_move, 3, null), new mframe_t(GameAI.ai_move, 2, null), new mframe_t(GameAI.ai_move, 0, null), new mframe_t(GameAI.ai_move, 1, null)};
        static mmove_t mutant_move_pain3 = new mmove_t(FRAME_pain301, FRAME_pain311, mutant_frames_pain3, mutant_run);
        static EntPainAdapter mutant_pain = new AnonymousEntPainAdapter();
        private sealed class AnonymousEntPainAdapter : EntPainAdapter
		{
			
            public override string GetID()
            {
                return "mutant_pain";
            }

            public override void Pain(edict_t self, edict_t other, float kick, int damage)
            {
                float r;
                if (self.health < (self.max_health / 2))
                    self.s.skinnum = 1;
                if (GameBase.level.time < self.pain_debounce_time)
                    return;
                self.pain_debounce_time = GameBase.level.time + 3;
                if (GameBase.skill.value == 3)
                    return;
                r = Lib.Random();
                if (r < 0.33)
                {
                    GameBase.gi.Sound(self, Defines.CHAN_VOICE, sound_pain1, 1, Defines.ATTN_NORM, 0);
                    self.monsterinfo.currentmove = mutant_move_pain1;
                }
                else if (r < 0.66)
                {
                    GameBase.gi.Sound(self, Defines.CHAN_VOICE, sound_pain2, 1, Defines.ATTN_NORM, 0);
                    self.monsterinfo.currentmove = mutant_move_pain2;
                }
                else
                {
                    GameBase.gi.Sound(self, Defines.CHAN_VOICE, sound_pain1, 1, Defines.ATTN_NORM, 0);
                    self.monsterinfo.currentmove = mutant_move_pain3;
                }
            }
        }

        static EntThinkAdapter mutant_dead = new AnonymousEntThinkAdapter19();
        private sealed class AnonymousEntThinkAdapter19 : EntThinkAdapter
		{
			
            public override string GetID()
            {
                return "mutant_dead";
            }

            public override bool Think(edict_t self)
            {
                Math3D.VectorSet(self.mins, -16, -16, -24);
                Math3D.VectorSet(self.maxs, 16, 16, -8);
                self.movetype = Defines.MOVETYPE_TOSS;
                self.svflags |= Defines.SVF_DEADMONSTER;
                GameBase.gi.Linkentity(self);
                M.M_FlyCheck.Think(self);
                return true;
            }
        }

        static mframe_t[] mutant_frames_death1 = new mframe_t[]{new mframe_t(GameAI.ai_move, 0, null), new mframe_t(GameAI.ai_move, 0, null), new mframe_t(GameAI.ai_move, 0, null), new mframe_t(GameAI.ai_move, 0, null), new mframe_t(GameAI.ai_move, 0, null), new mframe_t(GameAI.ai_move, 0, null), new mframe_t(GameAI.ai_move, 0, null), new mframe_t(GameAI.ai_move, 0, null), new mframe_t(GameAI.ai_move, 0, null)};
        static mmove_t mutant_move_death1 = new mmove_t(FRAME_death101, FRAME_death109, mutant_frames_death1, mutant_dead);
        static mframe_t[] mutant_frames_death2 = new mframe_t[]{new mframe_t(GameAI.ai_move, 0, null), new mframe_t(GameAI.ai_move, 0, null), new mframe_t(GameAI.ai_move, 0, null), new mframe_t(GameAI.ai_move, 0, null), new mframe_t(GameAI.ai_move, 0, null), new mframe_t(GameAI.ai_move, 0, null), new mframe_t(GameAI.ai_move, 0, null), new mframe_t(GameAI.ai_move, 0, null), new mframe_t(GameAI.ai_move, 0, null), new mframe_t(GameAI.ai_move, 0, null)};
        static mmove_t mutant_move_death2 = new mmove_t(FRAME_death201, FRAME_death210, mutant_frames_death2, mutant_dead);
        static EntDieAdapter mutant_die = new AnonymousEntDieAdapter();
        private sealed class AnonymousEntDieAdapter : EntDieAdapter
		{
			
            public override string GetID()
            {
                return "mutant_die";
            }

            public override void Die(edict_t self, edict_t inflictor, edict_t attacker, int damage, float[] point)
            {
                int n;
                if (self.health <= self.gib_health)
                {
                    GameBase.gi.Sound(self, Defines.CHAN_VOICE, GameBase.gi.Soundindex("misc/udeath.wav"), 1, Defines.ATTN_NORM, 0);
                    for (n = 0; n < 2; n++)
                        GameMisc.ThrowGib(self, "models/objects/gibs/bone/tris.md2", damage, Defines.GIB_ORGANIC);
                    for (n = 0; n < 4; n++)
                        GameMisc.ThrowGib(self, "models/objects/gibs/sm_meat/tris.md2", damage, Defines.GIB_ORGANIC);
                    GameMisc.ThrowHead(self, "models/objects/gibs/head2/tris.md2", damage, Defines.GIB_ORGANIC);
                    self.deadflag = Defines.DEAD_DEAD;
                    return;
                }

                if (self.deadflag == Defines.DEAD_DEAD)
                    return;
                GameBase.gi.Sound(self, Defines.CHAN_VOICE, sound_death, 1, Defines.ATTN_NORM, 0);
                self.deadflag = Defines.DEAD_DEAD;
                self.takedamage = Defines.DAMAGE_YES;
                self.s.skinnum = 1;
                if (Lib.Random() < 0.5)
                    self.monsterinfo.currentmove = mutant_move_death1;
                else
                    self.monsterinfo.currentmove = mutant_move_death2;
            }
        }

        public static EntThinkAdapter SP_monster_mutant = new AnonymousEntThinkAdapter20();
        private sealed class AnonymousEntThinkAdapter20 : EntThinkAdapter
		{
			
            public override string GetID()
            {
                return "SP_monster_mutant";
            }

            public override bool Think(edict_t self)
            {
                if (GameBase.deathmatch.value != 0)
                {
                    GameUtil.G_FreeEdict(self);
                    return false;
                }

                sound_swing = GameBase.gi.Soundindex("mutant/mutatck1.wav");
                sound_hit = GameBase.gi.Soundindex("mutant/mutatck2.wav");
                sound_hit2 = GameBase.gi.Soundindex("mutant/mutatck3.wav");
                sound_death = GameBase.gi.Soundindex("mutant/mutdeth1.wav");
                sound_idle = GameBase.gi.Soundindex("mutant/mutidle1.wav");
                sound_pain1 = GameBase.gi.Soundindex("mutant/mutpain1.wav");
                sound_pain2 = GameBase.gi.Soundindex("mutant/mutpain2.wav");
                sound_sight = GameBase.gi.Soundindex("mutant/mutsght1.wav");
                sound_search = GameBase.gi.Soundindex("mutant/mutsrch1.wav");
                sound_step1 = GameBase.gi.Soundindex("mutant/step1.wav");
                sound_step2 = GameBase.gi.Soundindex("mutant/step2.wav");
                sound_step3 = GameBase.gi.Soundindex("mutant/step3.wav");
                sound_thud = GameBase.gi.Soundindex("mutant/thud1.wav");
                self.movetype = Defines.MOVETYPE_STEP;
                self.solid = Defines.SOLID_BBOX;
                self.s.modelindex = GameBase.gi.Modelindex("models/monsters/mutant/tris.md2");
                Math3D.VectorSet(self.mins, -32, -32, -24);
                Math3D.VectorSet(self.maxs, 32, 32, 48);
                self.health = 300;
                self.gib_health = -120;
                self.mass = 300;
                self.pain = mutant_pain;
                self.die = mutant_die;
                self.monsterinfo.stand = mutant_stand;
                self.monsterinfo.walk = mutant_walk;
                self.monsterinfo.run = mutant_run;
                self.monsterinfo.dodge = null;
                self.monsterinfo.attack = mutant_jump;
                self.monsterinfo.melee = mutant_melee;
                self.monsterinfo.sight = mutant_sight;
                self.monsterinfo.search = mutant_search;
                self.monsterinfo.idle = mutant_idle;
                self.monsterinfo.checkattack = mutant_checkattack;
                GameBase.gi.Linkentity(self);
                self.monsterinfo.currentmove = mutant_move_stand;
                self.monsterinfo.scale = MODEL_SCALE;
                GameAI.walkmonster_start.Think(self);
                return true;
            }
        }
    }
}