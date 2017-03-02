using GoogleMapsGeocoding.Common;
using System.Threading.Tasks;

namespace GoogleMapsGeocoding
{
    public interface IGeocoder
    {
        string ApiKey { get; }

        GeocodeResponse Geocode(string address);

        GeocodeResponse ReverseGeocode(double latitude, double longitude);

        string Geocode(string address, ResponseFormat responseFormat);

        string ReverseGeocode(double latitude, double longitude, ResponseFormat responseFormat);

        GeocodeResponse FromJson(string json);

        GeocodeResponse FromXml(string xml);

        Task<GeocodeResponse> GeocodeAsync(string address);

        Task<GeocodeResponse> ReverseGeocodeAsync(double latitude, double longitude);

        Task<string> GeocodeAsync(string address, ResponseFormat responseFormat);

        Task<string> ReverseGeocodeAsync(double latitude, double longitude, ResponseFormat responseFormat);

    }
}
