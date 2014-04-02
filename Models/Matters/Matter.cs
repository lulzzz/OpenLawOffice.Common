﻿// -----------------------------------------------------------------------
// <copyright file="MatterContact.cs" company="Nodine Legal, LLC">
// Licensed to Nodine Legal, LLC under one
// or more contributor license agreements.  See the NOTICE file
// distributed with this work for additional information
// regarding copyright ownership.  Nodine Legal, LLC licenses this file
// to you under the Apache License, Version 2.0 (the
// "License"); you may not use this file except in compliance
// with the License.  You may obtain a copy of the License at
// 
//  http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing,
// software distributed under the License is distributed on an
// "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
// KIND, either express or implied.  See the License for the
// specific language governing permissions and limitations
// under the License.
// </copyright>
// -----------------------------------------------------------------------

namespace OpenLawOffice.Common.Models.Matters
{
    using System;
    using AutoMapper;
    using System.Collections.Generic;

    [MapMe]
    [Can(CanFlags.Get | CanFlags.Create | CanFlags.Update | CanFlags.Delete)]
    public class Matter : Core, Security.ISecuredResource, IHasGuidId
    {
        public Guid? Id { get; set; }
        public Guid? ParentId { get; set; }
        [ShowInList]
        public string Title { get; set; }
        public string Synopsis { get; set; }
        public Security.SecuredResource SecuredResource { get; set; }

        public Matter()
        {
        }
        
        public override void BuildMappings()
        {
            Mapper.CreateMap<Rest.Requests.Matters.Matter, Matter>()
                .ForMember(dst => dst.IsStub, opt => opt.UseValue(false))
                .ForMember(dst => dst.UtcCreated, opt => opt.UseValue(null))
                .ForMember(dst => dst.UtcModified, opt => opt.UseValue(null))
                .ForMember(dst => dst.UtcDisabled, opt => opt.UseValue(null))
                .ForMember(dst => dst.CreatedBy, opt => opt.UseValue(null))
                .ForMember(dst => dst.ModifiedBy, opt => opt.UseValue(null))
                .ForMember(dst => dst.DisabledBy, opt => opt.UseValue(null))
                .ForMember(dst => dst.Id, opt => opt.MapFrom(src => src.Id))
                .ForMember(dst => dst.ParentId, opt => opt.MapFrom(src => src.ParentId))
                .ForMember(dst => dst.Title, opt => opt.MapFrom(src => src.Title))
                .ForMember(dst => dst.Synopsis, opt => opt.MapFrom(src => src.Synopsis))
                .ForMember(dst => dst.SecuredResource, opt => opt.Ignore());

            //Mapper.CreateMap<Matter, Rest.Requests.Matters.Matter>()
            //    .ForMember(dst => dst.Received, opt => opt.Ignore())
            //    .ForMember(dst => dst.AuthToken, opt => opt.Ignore())
            //    .ForMember(dst => dst.Id, opt => opt.MapFrom(src => src.Id))
            //    .ForMember(dst => dst.ParentId, opt => opt.MapFrom(src => src.ParentId))
            //    .ForMember(dst => dst.Title, opt => opt.MapFrom(src => src.Title))
            //    .ForMember(dst => dst.Synopsis, opt => opt.MapFrom(src => src.Synopsis))
            //    .ForMember(dst => dst.TagQuery, opt => opt.ResolveUsing(model =>
            //    {
            //        if (model.Tags != null && model.Tags.Count > 0)
            //            return string.Join(";", model.Tags);
            //        return null;
            //    }));

            //Mapper.CreateMap<Matter, Rest.Responses.Matters.Matter>()
            //    .ForMember(dst => dst.UtcCreated, opt => opt.MapFrom(src => src.UtcCreated))
            //    .ForMember(dst => dst.UtcModified, opt => opt.MapFrom(src => src.UtcModified))
            //    .ForMember(dst => dst.UtcDisabled, opt => opt.MapFrom(src => src.UtcDisabled))
            //    .ForMember(dst => dst.CreatedBy, opt => opt.MapFrom(src => src.CreatedBy))
            //    .ForMember(dst => dst.ModifiedBy, opt => opt.MapFrom(src => src.ModifiedBy))
            //    .ForMember(dst => dst.DisabledBy, opt => opt.MapFrom(src => src.DisabledBy))
            //    .ForMember(dst => dst.Id, opt => opt.MapFrom(src => src.Id))
            //    .ForMember(dst => dst.ParentId, opt => opt.MapFrom(src => src.ParentId))
            //    .ForMember(dst => dst.Title, opt => opt.MapFrom(src => src.Title))
            //    .ForMember(dst => dst.Synopsis, opt => opt.MapFrom(src => src.Synopsis));

            Mapper.CreateMap<Rest.Responses.Matters.Matter, Matter>()
                .ForMember(dst => dst.IsStub, opt => opt.UseValue(false))
                .ForMember(dst => dst.UtcCreated, opt => opt.MapFrom(src => src.UtcCreated))
                .ForMember(dst => dst.UtcModified, opt => opt.MapFrom(src => src.UtcModified))
                .ForMember(dst => dst.UtcDisabled, opt => opt.MapFrom(src => src.UtcDisabled))
                .ForMember(dst => dst.CreatedBy, opt => opt.MapFrom(src => src.CreatedBy))
                .ForMember(dst => dst.ModifiedBy, opt => opt.MapFrom(src => src.ModifiedBy))
                .ForMember(dst => dst.DisabledBy, opt => opt.MapFrom(src => src.DisabledBy))
                .ForMember(dst => dst.Id, opt => opt.MapFrom(src => src.Id))
                .ForMember(dst => dst.ParentId, opt => opt.MapFrom(src => src.ParentId))
                .ForMember(dst => dst.Title, opt => opt.MapFrom(src => src.Title))
                .ForMember(dst => dst.Synopsis, opt => opt.MapFrom(src => src.Synopsis))
                .ForMember(dst => dst.SecuredResource, opt => opt.Ignore());
        }
    }
}
