﻿using CardsForMemoryLibrary.IServices;
using CardsForMemoryLibrary.Services;
using CardsForMemory.Services;
using CardsForMemoryLibrary.ViewModels;
using GalaSoft.MvvmLight.Ioc;

namespace CardsForMemory.Locator {
    /// <summary>
    ///     定位器
    /// </summary>
    public class ViewModelLocator {
        /// <summary>
        ///     ViewModel定位器单件
        /// </summary>
        public static readonly ViewModelLocator Instance = new ViewModelLocator();

        public PackagePageViewModel PackagePageViewModel => SimpleIoc.Default.GetInstance<PackagePageViewModel>();

        public RememberPageViewModel RememberPageViewModel => SimpleIoc.Default.GetInstance<RememberPageViewModel>();

        public EditPackagePageViewModel EditPackagePageViewModel => SimpleIoc.Default.GetInstance<EditPackagePageViewModel>();

        public MainPageViewModel MainPageViewModel => SimpleIoc.Default.GetInstance<MainPageViewModel>();

        public PackageInfoViewModel PackageInfoViewModel => SimpleIoc.Default.GetInstance<PackageInfoViewModel>();

        public CardInfoViewModel CardInfoViewModel => SimpleIoc.Default.GetInstance<CardInfoViewModel>();

        public CardViewViewModel CardViewViewModel => SimpleIoc.Default.GetInstance<CardViewViewModel>();

        public QueryNewOldViewModel QueryNewOldViewModel => SimpleIoc.Default.GetInstance<QueryNewOldViewModel>();

        public INavigationService INavigationService => SimpleIoc.Default.GetInstance<INavigationService>();

        /// <summary>
        ///     私有构造
        /// </summary>
        private ViewModelLocator() {
            SimpleIoc.Default.Register<ICardService, CardServiceEx>();
            SimpleIoc.Default.Register<IPackageService, PackageServiceEx>();
            SimpleIoc.Default.Register<ISqliteConnectionService, SqliteConnectionService>();
            SimpleIoc.Default.Register<IFeedbackService, FeedbackService>();
            SimpleIoc.Default.Register<INavigationService, NavigationService>();
            SimpleIoc.Default.Register<IToastService, ToastService>();
            SimpleIoc.Default.Register<ISettingService, SettingService>();
            SimpleIoc.Default.Register<PackagePageViewModel>();
            SimpleIoc.Default.Register<RememberPageViewModel>();
            SimpleIoc.Default.Register<EditPackagePageViewModel>();
            SimpleIoc.Default.Register<MainPageViewModel>();
            SimpleIoc.Default.Register<PackageInfoViewModel>();
            SimpleIoc.Default.Register<CardInfoViewModel>();
            SimpleIoc.Default.Register<CardViewViewModel>();
            SimpleIoc.Default.Register<QueryNewOldViewModel>();

        }
    }
}
