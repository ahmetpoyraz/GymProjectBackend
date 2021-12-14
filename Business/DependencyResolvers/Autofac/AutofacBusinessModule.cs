using Autofac;
using Autofac.Extras.DynamicProxy;
using AutofacSerilogIntegration;
using Business.Abstract;
using Business.Conrete;
using Castle.DynamicProxy;
using Core.Utilities.Interceptors;
using DataAccess.Abstract;
using DataAccess.Concrete;
using DataAccess.Concrete.Dapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.DependencyResolvers.Autofac
{
    public class AutofacBusinessModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            //Business Injection

            builder.RegisterType<DenemeManager>().As<IDenemeService>().SingleInstance();
            builder.RegisterType<MemberManager>().As<IMemberService>().SingleInstance();
            builder.RegisterType<MemberMeasureMentManager>().As<IMemberMeasurementService>().SingleInstance();

            //DataAccess Injection

            builder.RegisterType<DenemeDal>().As<IDenemeDal>().SingleInstance();
            builder.RegisterType<DapperMemberDal>().As<IMemberDal>().SingleInstance();
            builder.RegisterType<DapperMemberMeasurementDal>().As<IMemberMeasurementDal>().SingleInstance();

            var assembly = System.Reflection.Assembly.GetExecutingAssembly();

            builder.RegisterAssemblyTypes(assembly).AsImplementedInterfaces()
                .EnableInterfaceInterceptors(new ProxyGenerationOptions()
                {
                    Selector = new AspectInterceptorSelector()
                }).SingleInstance();
            //
            builder.RegisterLogger();
            //builder.Services.AddScoped<IDenemeService, DenemeManager>();
            //builder.Services.AddScoped<IMemberService, MemberManager>();
            //builder.Services.AddScoped<IMemberMeasurementService, MemberMeasureMentManager>();
            //

            //builder.Services.AddScoped<IDenemeDal, DenemeDal>();
            //builder.Services.AddScoped<IMemberDal, DapperMemberDal>();
            //builder.Services.AddScoped<IMemberMeasurementDal, DapperMemberMeasurementDal>();

        }
    }
}
