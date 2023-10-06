using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tarefa_2.ApplicationCore.DTOs;
using tarefa_2.ApplicationCore.Entities;
using tarefa_2.ApplicationCore.Interfaces;
using tarefa_2.ApplicationCore.Notificador;
using tarefa_2.Infrastructure.Data.Repositories;

namespace tarefa_2.ApplicationCore.Services
{
    public class CidadeService : ICidadeService
    {
        private readonly INotificador _notificador;
        private readonly IMapper _mapper;
        private readonly IUnitOfWork _unitOfWork;
        private readonly ICidadeRepository _repositorio;
        private readonly IEstadoRepository _repositorioEstado;

        public CidadeService(INotificador notificador, IMapper mapper, IUnitOfWork unitOfWork, ICidadeRepository repositorio, IEstadoRepository repositorioEstado)
        {
            _notificador = notificador;
            _mapper = mapper;
            _unitOfWork = unitOfWork;
            _repositorio = repositorio;
            _repositorioEstado = repositorioEstado;
        }

        public async Task<CidadeDTO> AdicionarAsync(CidadeDTO cidadeDTO)
        {
            if (! await Validar(cidadeDTO)) return null;

            var cidade = _mapper.Map<Cidade>(cidadeDTO);

            _repositorio.Adicionar(cidade);
            await _unitOfWork.CommitarAsync();

            return _mapper.Map<CidadeDTO>(cidade);
        }


        public async Task<CidadeDTO> AtualizarAsync(CidadeDTO cidadeDTO)
        {
            if (!await Validar(cidadeDTO)) return null;

            var cidade = _mapper.Map<Cidade>(cidadeDTO);

            _repositorio.Atualizar(cidade);
            await _unitOfWork.CommitarAsync();

            return _mapper.Map<CidadeDTO>(cidade);
        }


        private async Task<bool> Validar(CidadeDTO cidadeDTO)
        {
            if (await _repositorioEstado.ObterPorIdAsync(cidadeDTO.EstadoId) == null)
                _notificador.Adicionar(new Notificacao("Estado informado inválido !"));

            if (_notificador.TemNotificacao())
                return false;

            return true;
        }


        public async Task<CidadeDTO> ObterPorIdAsync(int id)
        {
            var cidade = await _repositorio.ObterPorIdAsync(id);

            return _mapper.Map<CidadeDTO>(cidade);
        }


        public async Task<List<CidadeDTO>> ObterPorEstadoAsync(string estado)
        {
            var cidades = await _repositorio.ObterPorEstadoAsync(estado);

            return _mapper.Map<List<CidadeDTO>>(cidades);
        }


        public async Task<List<CidadeDTO>> ObterPorEstadoPaginadaAsync(string estado, int skip, int take)
        {
            var cidades = await _repositorio.ObterPorEstadoPaginadaAsync(estado,skip,take);

            return _mapper.Map<List<CidadeDTO>>(cidades);
        }


        public async Task<CidadeDTO> ObterPorNomeAsync(string nomeCidade)
        {
            var cidade = await _repositorio.ObterPorNomeAsync(nomeCidade);

            return _mapper.Map<CidadeDTO>(cidade);
        }


    }

}
