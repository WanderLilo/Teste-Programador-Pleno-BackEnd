using AutoMapper;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using tarefa_3.ApplicationCore.Configurations;
using tarefa_3.ApplicationCore.DTOs;
using tarefa_3.ApplicationCore.Entities;
using tarefa_3.ApplicationCore.Interfaces;
using tarefa_3.ApplicationCore.Notificador;
using tarefa_3.ApplicationCore.Utils;

namespace tarefa_3.ApplicationCore.Services
{
    public class PessoaService : IPessoaService
    {
        private readonly IOptions<AppSettings> _appSettings;
        private readonly INotificador _notificador;
        private readonly IMapper _mapper;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IPessoaRepository _repositorio;

        public PessoaService(IOptions<AppSettings> appSettings, INotificador notificador, IMapper mapper, IUnitOfWork unitOfWork, IPessoaRepository repositorio)
        {
            _appSettings = appSettings;
            _notificador = notificador;
            _mapper = mapper;
            _unitOfWork = unitOfWork;
            _repositorio = repositorio;
        }

        public async Task<PessoaDTO> AdicionarAsync(PessoaDTO pessoaDTO)
        {
            if (! await Validar(pessoaDTO)) return null;

            var pessoa = _mapper.Map<Pessoa>(pessoaDTO);

            _repositorio.Adicionar(pessoa);
            await _unitOfWork.CommitarAsync();

            return _mapper.Map<PessoaDTO>(pessoa);
        }


        private async Task<bool> Validar(PessoaDTO pessoaDTO)
        {
            if (!CpfCnpjUtils.IsValid(pessoaDTO.Cpf))
                _notificador.Adicionar(new Notificacao("Cpf da pessoa inválido !"));

            if (!await ValidarCidadeExiste(pessoaDTO.CidadeId))
                _notificador.Adicionar(new Notificacao("Cidade não cadastrada na API tarefa-2"));

            if (_notificador.TemNotificacao())
                return false;

            return true;
        }


        private async Task<bool> ValidarCidadeExiste(int cidadeId)
        {
            HttpClient httpClient = new HttpClient();

            try
            {
                var response = await httpClient.GetAsync($"{_appSettings.Value.UrlApiCidade}{cidadeId}");

                if (response.StatusCode == HttpStatusCode.NotFound)
                    return false;

            }
            catch (Exception ex)
            {
                _notificador.Adicionar(new Notificacao("Erro durante chamada API Tarefa-2 para validar se cidade existe. Detalhes do erro: "+ex.Message));
                return false;
            }
            finally
            { 
                httpClient.Dispose(); 
            }

            return true;
        }



    }

}
