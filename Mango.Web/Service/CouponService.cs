﻿
using Mango.Web.Models;
using Mango.Web.Service.IService;
using Mango.Web.Utility;
using static Mango.Web.Utility.SD;

namespace Mango.Web.Service
{
    public class CouponService : ICouponService
    {
        private readonly IBaseService _baseService;

        public CouponService(IBaseService baseService) 
        { 
            _baseService = baseService;
        }

        public async Task<ResponseDto?> CreateCouponsAsync(CouponDto couponDto)
        {
            return await _baseService.SendAsync(new RequestDto
            {
                ApiType = ApiType.POST,
                Data = couponDto,
                Url = SD.CouponAPIBase + "/api/coupon"
            });
        }

        public async Task<ResponseDto?> DeleteCouponsAsync(int id)
        {
            return await _baseService.SendAsync(new RequestDto
            {
                ApiType = ApiType.DELETE,
                Url = SD.CouponAPIBase + "/api/coupon/" + id
            });
        }

        public async Task<ResponseDto?> GetAllCouponAsync()
        {
            return await _baseService.SendAsync(new RequestDto
            {
                ApiType = ApiType.GET,
                Url = SD.CouponAPIBase + "/api/coupon"
            });
        }

        public async Task<ResponseDto?> GetCouponAsync(string couponeCode)
        {
            return await _baseService.SendAsync(new RequestDto
            {
                ApiType = ApiType.GET,
                Url = SD.CouponAPIBase + "/api/coupon/GetByCode/" + couponeCode
            });
        }

        public async Task<ResponseDto?> GetCouponByIdAsync(int id)
        {
            return await _baseService.SendAsync(new RequestDto
            {
                ApiType = ApiType.GET,
                Url = SD.CouponAPIBase + "/api/coupon/" + id
            });
        }

        public async Task<ResponseDto?> UpdateCouponsAsync(CouponDto couponDto)
        {
            return await _baseService.SendAsync(new RequestDto
            {
                ApiType = ApiType.PUT,
                Data = couponDto,
                Url = SD.CouponAPIBase + "/api/coupon"
            });
        }
    }
}
