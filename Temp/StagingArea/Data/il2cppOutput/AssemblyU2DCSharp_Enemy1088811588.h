#pragma once

#include "il2cpp-config.h"

#ifndef _MSC_VER
# include <alloca.h>
#else
# include <malloc.h>
#endif

#include <stdint.h>


#include "UnityEngine_UnityEngine_MonoBehaviour1158329972.h"

#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// Enemy
struct  Enemy_t1088811588  : public MonoBehaviour_t1158329972
{
public:
	// System.Single Enemy::width
	float ___width_2;
	// System.Single Enemy::height
	float ___height_3;

public:
	inline static int32_t get_offset_of_width_2() { return static_cast<int32_t>(offsetof(Enemy_t1088811588, ___width_2)); }
	inline float get_width_2() const { return ___width_2; }
	inline float* get_address_of_width_2() { return &___width_2; }
	inline void set_width_2(float value)
	{
		___width_2 = value;
	}

	inline static int32_t get_offset_of_height_3() { return static_cast<int32_t>(offsetof(Enemy_t1088811588, ___height_3)); }
	inline float get_height_3() const { return ___height_3; }
	inline float* get_address_of_height_3() { return &___height_3; }
	inline void set_height_3(float value)
	{
		___height_3 = value;
	}
};

struct Enemy_t1088811588_StaticFields
{
public:
	// System.Int32 Enemy::Count
	int32_t ___Count_4;

public:
	inline static int32_t get_offset_of_Count_4() { return static_cast<int32_t>(offsetof(Enemy_t1088811588_StaticFields, ___Count_4)); }
	inline int32_t get_Count_4() const { return ___Count_4; }
	inline int32_t* get_address_of_Count_4() { return &___Count_4; }
	inline void set_Count_4(int32_t value)
	{
		___Count_4 = value;
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
