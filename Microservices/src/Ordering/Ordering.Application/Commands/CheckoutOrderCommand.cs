using MediatR;
using Ordering.Application.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ordering.Application.Commands
{
	public class CheckoutOrderCommand : IRequest<OrderResponse>
	{

	}
}
