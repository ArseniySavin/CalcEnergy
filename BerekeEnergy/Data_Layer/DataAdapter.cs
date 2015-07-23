using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BerekeEnergy.Models;


namespace BerekeEnergy.Data_Layer
{
    public class DataAdapter
    {
        BeEneDataContext beEbergyContext;
        public DataAdapter()
        {
            beEbergyContext = new BeEneDataContext();
        }

        void Commit()
        {
            beEbergyContext.SubmitChanges();
        }

        public List<TDC> GetAllTypeDeviceForList()
        {
            return (from d in beEbergyContext.d_type_devices
                    select new TDC
                    {
                        label = d.code,
                        value =  d.Id
                    }).ToList();
        }

        public List<TDC> GetAllTariffForList()
        {
            return (from d in beEbergyContext.d_tariffs
                    select new TDC
                    {
                        label = d.code,
                        value = d.Id
                    }).ToList();
        }

        #region d_tariff
        public List<DTariffModel> GetAllTariff()
        {
            return (from d in beEbergyContext.d_tariffs
                    select new DTariffModel
                    {
                        Id = d.Id,
                        code = d.code,
                        name = d.name,
                        tariff_1 = d.tariff_1,
                        tariff_2 = d.tariff_2,
                        tariff_3 = d.tariff_3,
                        tariff_4 = d.tariff_4
                    }).ToList();
        }

        d_tariff GetTariffById(int id)
        {
            return beEbergyContext.d_tariffs.SingleOrDefault(m => m.Id == id);
        }

        DTariffModel GetTariffById(d_tariff Tariff)
        {
            return (from d in beEbergyContext.d_tariffs
                    where d.Id == Tariff.Id
                    select new DTariffModel
                    {
                        Id = d.Id,
                        code = d.code,
                        name = d.name,
                        tariff_1 = d.tariff_1,
                        tariff_2 = d.tariff_2,
                        tariff_3 = d.tariff_3,
                        tariff_4 = d.tariff_4
                    }).SingleOrDefault();
        }

        public DTariffModel InsertTariff(DTariffModel Tariff)
        {
            d_tariff dt = new d_tariff();

            dt.code = Tariff.code;
            dt.name = Tariff.name;
            dt.tariff_1 = Tariff.tariff_1;
            dt.tariff_2 = Tariff.tariff_2;
            dt.tariff_3 = Tariff.tariff_3;
            dt.tariff_4 = Tariff.tariff_4;

            beEbergyContext.d_tariffs.InsertOnSubmit(dt);
            Commit();

            Tariff.Id = dt.Id;

            return Tariff;
        }

        public DTariffModel UpdateTariff(DTariffModel Tariff)
        {
            d_tariff dtd = GetTariffById(Tariff.Id);

            dtd.code = Tariff.code;
            dtd.name = Tariff.name;
            dtd.tariff_1 = Tariff.tariff_1;
            dtd.tariff_2 = Tariff.tariff_2;
            dtd.tariff_3 = Tariff.tariff_3;
            dtd.tariff_4 = Tariff.tariff_4;

            Commit();

            return Tariff;

        }

        public void DeleteTariff(DTariffModel Tariff)
        {
            d_tariff dtd = GetTariffById(Tariff.Id);

            beEbergyContext.d_tariffs.DeleteOnSubmit(dtd);

            Commit();
        }
        #endregion

        #region d_type_device
        public List<DTypeDeviceModel> GetAllTypeDevice()
        {
            return (from d in beEbergyContext.d_type_devices
                    select new DTypeDeviceModel
                    {
                        Id = d.Id,
                        code = d.code,
                        name = d.name
                    }).ToList();
        }

        d_type_device GetTypeDeviceById(int id)
        {
            return beEbergyContext.d_type_devices.SingleOrDefault(m => m.Id == id);
        }

        DTypeDeviceModel GetTypeDeviceById(d_type_device TDevice)
        {
            return (from d in beEbergyContext.d_type_devices
                    where d.Id == TDevice.Id
                    select new DTypeDeviceModel
                    {
                        Id = d.Id,
                        code = d.code,
                        name = d.name
                    }).SingleOrDefault();
        } 

        public DTypeDeviceModel InsertTypeDevice(DTypeDeviceModel TDevice)
        {
            d_type_device dtd = new d_type_device();

            dtd.code = TDevice.code;
            dtd.name = TDevice.name;

            beEbergyContext.d_type_devices.InsertOnSubmit(dtd);
            Commit();

            TDevice.Id = dtd.Id;

            return TDevice;
        }

        public DTypeDeviceModel UpdateTypeDevice(DTypeDeviceModel TDevice)
        {
            d_type_device dtd = GetTypeDeviceById(TDevice.Id);

            dtd.code = TDevice.code;
            dtd.name = TDevice.name;

            Commit();

            return TDevice;

        }

        public void DeleteTypeDevice(DTypeDeviceModel TDevice)
        {
            d_type_device dtd = GetTypeDeviceById(TDevice.Id);

            beEbergyContext.d_type_devices.DeleteOnSubmit(dtd);

            Commit();
        }
        #endregion

        #region d_device
        public List<DDevaceModel> GetAllDevice()
        {
            return (from d in beEbergyContext.d_devices
                    select new DDevaceModel
                    {
                        Id = d.Id,
                        code = d.code,
                        name = d.name,
                        coefficient = d.coefficient,
                        TypeDevice = GetTypeDeviceById(d.d_type_device),
                        Tariff = GetTariffById(d.d_tariff)
                    }).ToList();
        }

        d_device GetDeviceById(int id)
        {
            return beEbergyContext.d_devices.SingleOrDefault(m => m.Id == id);
        }

        public DDevaceModel InsertDevice(DDevaceModel Device)
        {
            d_device dv = new d_device();

            dv.code = Device.code;
            dv.name = Device.name;
            dv.coefficient = Device.coefficient;
            dv.device_id = Device.TypeDevice.Id;
            dv.tariff_Id = Device.Tariff.Id;

            beEbergyContext.d_devices.InsertOnSubmit(dv);
            Commit();

            Device.Id = dv.Id;

            return Device;
        }

        public DDevaceModel UpdateDevice(DDevaceModel Device)
        {
            d_device dd = GetDeviceById(Device.Id);

            dd.code = Device.code;
            dd.name = Device.name;
            dd.coefficient = Device.coefficient;
            dd.device_id = Device.TypeDevice.Id;
            dd.tariff_Id = Device.Tariff.Id;

            Commit();

            Device.TypeDevice.name = dd.d_type_device.name;

            return Device;

        }

        public void DeleteDevice(DDevaceModel Device)
        {
            d_tariff dtd = GetTariffById(Device.Id);

            beEbergyContext.d_tariffs.DeleteOnSubmit(dtd);

            Commit();
        }
        #endregion
    }
}