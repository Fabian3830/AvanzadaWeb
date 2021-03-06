﻿using System;
using System.Collections.Generic;
using System.Text;
using ent = DO.Interface;
using System.Threading.Tasks;
using Newtonsoft.Json;
using DAL;
using data = DO.Objetos;

namespace BS
{
    public class TbCliente : ent.ICRUD<data.TbCliente>
    {

        public async Task<string> Delete(string id)
        {
            if (string.IsNullOrEmpty(id)) return "Invalid ID";
            await new DAL.TbCliente().Remove(id);
            return "";
        }

        public async Task<IEnumerable<DO.Objetos.TbCliente>> GetAll()
        {
            var objetos = await new DAL.TbCliente().Get();
            //return JsonConvert.SerializeObject(objetos);
            return objetos;
        }

        public async Task<DO.Objetos.TbCliente> GetOneById(string id)
        {
            var objeto = await new DAL.TbCliente().Get(id) ?? new data.TbCliente();
            return objeto;
        }

        public async Task<string> Insert(data.TbCliente entity)
        {
            await new DAL.TbCliente().Create(entity);
            return "insertado";
        }

        public async Task<string> Updated(string id, data.TbCliente entity)
        {
            if (string.IsNullOrEmpty(id)) return "Invalid ID";
            return await new DAL.TbCliente().Update(id, entity);
        }




        public async Task<IEnumerable<DO.Objetos.TbCliente>> customQuery(string query)
        {var objetos = await new DAL.TbCliente().customQuery(query);return objetos;}


        public async Task<data.TbCliente> Verify(data.credentials credential)
        {
            data.TbCliente cliente = await new DAL.TbCliente().Verify(credential);
            if (cliente.sCorreo != null)
            {
                if(cliente.sContrasena == credential.password)
                {
                    cliente.sContrasena = null;
                    return cliente;
                }
                else
                {
                    throw new ArgumentException("La contraseña del usuario es incorrecta");
                }
            }
            else
            {
                throw new ArgumentException("El usuario ingresado no existe");
            }
            
        }
    }
}
