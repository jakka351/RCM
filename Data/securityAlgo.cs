public class securityAccessAlgo {
            
            public object seed = "61 43 E7";
            
            public object real_key = "4E 8D e";
            
            public object s1 = 0x08;
            
            public object s2 = 0x30;
            
            public object s3 = 0x61;
            
            public object s4 = 0xA4;
            
            public object s5 = 0xC5;
            
            public object seed_int = (Convert.ToInt32(seed[0::2], 16) << 16) + (Convert.ToInt32(seed[3::5], 16) << 8) + Convert.ToInt32(seed[6::8], 16);
            
            public object or_ed_seed = (seed_int & 0xFF0000) >> 16 | seed_int & 0xFF00 | s1 << 24 | (seed_int & 0xff) << 16;
            
            public object mucked_value = 0xc541a9;
            
            public object a_bit = (or_ed_seed >> i & 1 ^ mucked_value & 1) << 23;
            
            public object v9 = a_bit | mucked_value >> 1;
            
            public object mucked_value = v10 & 0xEF6FD7 | ((v9 & 0x100000) >> 20 ^ (v8 & 0x800000) >> 23) << 20 | ((mucked_value >> 1 & 0x8000) >> 15 ^ (v8 & 0x800000) >> 23) << 15 | ((mucked_value >> 1 & 0x1000) >> 12 ^ (v8 & 0x800000) >> 23) << 12 | 32 * ((mucked_value >> 1 & 0x20) >> 5 ^ (v8 & 0x800000) >> 23) | 8 * ((mucked_value >> 1 & 8) >> 3 ^ (v8 & 0x800000) >> 23);
            
            public object v11 = ((s5 << 24 | s4 << 16 | s2 | s3 << 8) >> j & 1 ^ mucked_value & 1) << 23;
            
            public object v12 = v11 | mucked_value >> 1;
            
            public object v13 = v11 | mucked_value >> 1;
            
            public object v14 = v11 | mucked_value >> 1;
            
            public object mucked_value = v14 & 0xEF6FD7 | ((v13 & 0x100000) >> 20 ^ (v12 & 0x800000) >> 23) << 20 | ((mucked_value >> 1 & 0x8000) >> 15 ^ (v12 & 0x800000) >> 23) << 15 | ((mucked_value >> 1 & 0x1000) >> 12 ^ (v12 & 0x800000) >> 23) << 12 | 32 * ((mucked_value >> 1 & 0x20) >> 5 ^ (v12 & 0x800000) >> 23) | 8 * ((mucked_value >> 1 & 8) >> 3 ^ (v12 & 0x800000) >> 23);
            
            public object key = (mucked_value & 0xF0000) >> 16 | 16 * (mucked_value & 0xF) | ((mucked_value & 0xF00000) >> 20 | (mucked_value & 0xF000) >> 8) << 8 | (mucked_value & 0xFF0) >> 4 << 16;
        }
