#pragma once

#include "API.h"

#ifdef __cplusplus
extern "C" {
#endif

typedef struct {
	int64_t size;
	uint8_t* data;
} VPKEdit_Buffer_t;

#ifdef __cplusplus
} // extern "C"
#endif

VPKEDIT_API VPKEdit_Buffer_t vpkedit_buffer_new(size_t size);

VPKEDIT_API void vpkedit_buffer_free(VPKEdit_Buffer_t* buffer);
